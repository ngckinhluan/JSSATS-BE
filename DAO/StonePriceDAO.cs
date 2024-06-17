﻿using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class StonePriceDao 
{
    private readonly JssatsContext _context;
    public StonePriceDao()
    {
        _context = new JssatsContext();
    }
    public async Task<IEnumerable<Gem>> GetStonePrices()
    {
        return await _context.Gems.ToListAsync();
    }
    public async Task<Gem?> GetStonePriceById(string id)
    {
        return await _context.Gems.FindAsync(id);
    }
    public async Task<int> Create(Gem gem)
    {
        _context.Gems.Add(gem);
        return await _context.SaveChangesAsync();
    }
    public async Task<int> Update(Gem gem)
    {
        _context.Gems.Update(gem);
        return await _context.SaveChangesAsync();
    }
}