﻿using DataProvider.EntityFramework.Configs;

namespace DataProvider.EntityFramework.Repository;
public interface IUnitOfWork : IDisposable
{
    //IProductCategoryRepository ProductCategories { get; }
    Task<bool> CommitAsync();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    //public IImageRepo Images { get; }

    public async Task<bool> CommitAsync() => await _context.SaveChangesAsync() > 0;
    public void Dispose() => _context.Dispose();

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        //ProductCategories = new ProductCategoryRepository(_context);
    }
}