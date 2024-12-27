﻿using MediaVisualizer.DataAccess.Entities.Manwha;
using MediaVisualizer.Shared.Requests;
using Microsoft.EntityFrameworkCore;

namespace MediaVisualizer.DataAccess.Repositories;

public class ManwhaRepository:IManwhaRepository
{
    private readonly MediaVisualizerDbContext _dbContext;

    public ManwhaRepository(MediaVisualizerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Manwha>> GetList(FiltersRequest filters)
    {
        var query = _dbContext.Manwha
            .Include(x=>x.ManwhaChapters)
            .Include(x => x.Brands)
            .Include(x => x.Tags)
            .Include(x=>x.Artists)
            .Include(x=>x.Authors)
            .AsQueryable();

        if (filters == null)
            return await query.ToListAsync();

        if (filters.SortOrder != null)
        {
            query = filters.SortOrder switch
            {
                "asc" => query.OrderBy(x => x.Title),
                "desc" => query.OrderByDescending(x => x.Title),
                _ => query
            };
        }

        if (filters.BrandKeys != null && filters.BrandKeys.Count != 0)
            query = query.Where(x => x.Brands.Any(y => filters.BrandKeys.Contains(y.BrandKey)));

        if (filters.TagKeys != null && filters.TagKeys.Count != 0)
            query = query.Where(x => x.Tags.Any(y => filters.TagKeys.Contains(y.TagKey)));

        if (filters.ArtistKeys != null && filters.ArtistKeys.Count != 0)
            query = query.Where(x => x.Artists.Any(y => filters.ArtistKeys.Contains(y.ArtistKey)));

        if (filters.AuthorKeys != null && filters.AuthorKeys.Count != 0)
            query = query.Where(x => x.Authors.Any(y => filters.AuthorKeys.Contains(y.AuthorKey)));

        if (filters.Page != null && filters.Page > 0 && filters.Size != null && filters.Size > 0)
            query = query.Skip(filters.Size.Value * filters.Page.Value).Take(filters.Size.Value);

        return await query.ToListAsync();
    }

    public async Task<Manwha> Get(int manwhaKey)
    {
        return await _dbContext.Manwha
            .Include(x=>x.ManwhaChapters)
            .Include(x => x.Brands)
            .Include(x => x.Tags)
            .Include(x=>x.Artists)
            .Include(x=>x.Authors)
            .SingleOrDefaultAsync(x => x.ManwhaKey == manwhaKey);
    }
}

public interface IManwhaRepository
{
    public Task<Manwha> Get(int manwhaKey);
    public Task<IEnumerable<Manwha>> GetList(FiltersRequest filters);
}