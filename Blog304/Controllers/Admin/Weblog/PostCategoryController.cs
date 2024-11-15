using DataProvider.Assistant.Pagination;
using DataProvider.EntityFramework.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog304.Controllers.Admin.Weblog;
[Route("api/[controller]")]
[ApiController]
public class PostCategoryController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    public PostCategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    //[HttpPost("create-product-category")]
    //public async Task Create([FromBody] string data)
    //{
    //    var dto = await Task.Run(() => JsonSerializer.Deserialize<ProductCategory>(data));
    //    if (dto != null)
    //    {
    //        var imageDto = await _unitOfWork.Images.GetImageByPathAsync(dto.ImagePath);
    //        dto.ImageAlt = imageDto.Alt;
    //        dto.CreateDate = DateTime.Now; dto.ModifiedDate = DateTime.Now;
    //        var entity = await Task.Run(() => _mapper.Map<ProductCategoryEntity>(dto));
    //        await _unitOfWork.ProductCategories.AddAsync(entity);
    //        await _unitOfWork.CommitAsync();
    //    }
    //}

    //[HttpPut(ShopRoutes.ProductCategory + CRUDRouts.Update)]
    //public async Task Update([FromBody] string data)
    //{
    //    var dto = await Task.Run(() => JsonSerializer.Deserialize<ProductCategoryDto>(data));
    //    if (dto != null)
    //    {
    //        var imageDto = await _unitOfWork.Images.GetImageByPathAsync(dto.ImagePath);
    //        dto.ImageAlt = imageDto.Alt;
    //        dto.ModifiedDate = DateTime.Now;
    //        var entity = await Task.Run(() => _mapper.Map<ProductCategoryEntity>(dto));
    //        await Task.Run(() => _unitOfWork.ProductCategories.Update(entity));
    //        await _unitOfWork.CommitAsync();
    //    }
    //}

    //[HttpDelete(ShopRoutes.ProductCategory + CRUDRouts.Delete + "/{data:long}")]
    //public async Task Delete([FromRoute] long data)
    //{
    //    var entity = await _unitOfWork.ProductCategories.GetByIdAsync(data);
    //    await Task.Run(() => _unitOfWork.ProductCategories.Remove(entity));
    //    await _unitOfWork.CommitAsync();
    //}

    //[HttpGet(ShopRoutes.ProductCategory + CRUDRouts.ReadAll)]
    //public async Task<List<ProductCategoryDto>> GetAll() =>
    //    _mapper.Map<List<ProductCategoryDto>>(await _unitOfWork.ProductCategories.GetAllAsync());

    //[HttpGet(ShopRoutes.ProductCategory + CRUDRouts.ReadOneById + "/{data}")]
    //public async Task<ProductCategoryDto> GetById([FromRoute] long data) =>
    //    _mapper.Map<ProductCategoryDto>(await _unitOfWork.ProductCategories.GetByIdAsync(data));

    //[HttpPost(ShopRoutes.ProductCategory + CRUDRouts.ReadListByFilter)]
    //public async Task<PaginatedList<ProductCategoryDto>> GetListByFilter([FromBody] string data)
    //{
    //    var filter = await Task.Run(() => JsonSerializer.Deserialize<DefaultPaginationFilter>(data) ?? new());
    //    var entityList = await _unitOfWork.ProductCategories.GetListByFilterAsync(filter);
    //    return await Task.Run(() => _mapper.Map<PaginatedList<ProductCategoryDto>>(entityList));
    //}
}
