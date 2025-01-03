﻿using System.Linq.Expressions;
using MediaVisualizer.DataAccess.Entities.Anime;
using MediaVisualizer.Shared.Requests;
using Microsoft.EntityFrameworkCore;

namespace MediaVisualizer.DataAccess.Repositories;

public class AnimeRepository : IAnimeRepository
{
    private readonly MediaVisualizerDbContext _dbContext;

    public AnimeRepository(MediaVisualizerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<(int totalCount, IEnumerable<Anime>)> GetList(FiltersRequest filters)
    {
        var query = GetBaseQuery();

        var totalCount = await query.CountAsync();

        if (filters.SortOrder != null)
        {
            query = filters.SortOrder switch
            {
                "asc" => query.OrderBy(x => x.Title),
                "desc" => query.OrderByDescending(x => x.Title),
                _ => query
            };
        }

        if (filters.BrandIds != null && filters.BrandIds.Count != 0)
            query = query.Where(x => x.Brands.Any(y => filters.BrandIds.Contains(y.BrandId)));

        if (filters.TagIds != null && filters.TagIds.Count != 0)
            query = query.Where(x => x.Tags.Any(y => filters.TagIds.Contains(y.TagId)));

        if (filters.Page != null && filters.Page > 0 && filters.Size != null && filters.Size > 0)
            query = query.Skip(filters.Size.Value * (filters.Page.Value - 1)).Take(filters.Size.Value);

        var animes = await query.ToListAsync();

        return (totalCount, animes);
    }

    public async Task<Anime> Get(int animeKey)
    {
        var query = GetBaseQuery();
        return await query.FirstAsync(x => x.AnimeId == animeKey);
    }

    public async Task<Anime> GetRandom()
    {
        var query = GetBaseQuery();
        var count = await _dbContext.Animes.CountAsync();
        var randomIndex = new Random().Next(count);
        return await query.Skip(randomIndex).FirstAsync();
    }

    private IQueryable<Anime> GetBaseQuery()
    {
        return _dbContext.Animes
            .Include(x => x.AnimeChapters)
            .Include(x => x.Brands)
            .Include(x => x.Tags);
    }
}

public interface IAnimeRepository
{
    public Task<(int totalCount, IEnumerable<Anime>)> GetList(FiltersRequest filters);
    public Task<Anime> Get(int animeKey);
    Task<Anime> GetRandom();
}