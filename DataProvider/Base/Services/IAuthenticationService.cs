﻿using Blazored.LocalStorage;
using DataProvider.Base.Classes;
using DataProvider.Models.Command.Identity;
using DataProvider.Models.Result;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace DataProvider.Base.Services
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto?> RegisterUser(UserForRegistrationCommand userForRegistration);
        Task<LoginResultDto> Login(LoginCommand loginModel);
        Task Logout();
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        // i use ILocalStorageService(it's a nuget) here
        // to get or set user token's
        private readonly ILocalStorageService _localStorage;
        public AuthenticationService(HttpClient client, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorage)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }
        public async Task<RegistrationResponseDto?> RegisterUser(UserForRegistrationCommand userForRegistration)
        {
            var content = JsonSerializer.Serialize(userForRegistration);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var registrationResult = await _client.PostAsync("register-user", bodyContent);
            var registrationContent = await registrationResult.Content.ReadAsStringAsync();
            if (!registrationResult.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<RegistrationResponseDto>(registrationContent, _options);
            }
            return new RegistrationResponseDto { IsSuccessfulRegistration = true };
        }
        // get user login data and validate it
        public async Task<LoginResultDto> Login(LoginCommand loginModel)
        {
            var loginAsJson = JsonSerializer.Serialize(loginModel);
            var response = await _client.PostAsync("login-user", new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
            var loginResult = JsonSerializer.Deserialize<LoginResultDto>
                (await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }
            await _localStorage.SetItemAsync("authToken", loginResult.Token);

            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginResult.Token);

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);

            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");

            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _client.DefaultRequestHeaders.Authorization = null;
        }
    }
}
