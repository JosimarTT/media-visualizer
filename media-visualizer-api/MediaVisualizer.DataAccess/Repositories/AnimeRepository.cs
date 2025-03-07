﻿using MediaVisualizer.DataAccess.Entities;
using MediaVisualizer.Shared.Requests;
using Microsoft.EntityFrameworkCore;

namespace MediaVisualizer.DataAccess.Repositories;

public class AnimeRepository : IAnimeRepository
{
    private readonly MediaVisualizerDbContext _context;

    public AnimeRepository(MediaVisualizerDbContext context)
    {
        _context = context;
    }

    public async Task<(int totalCount, IEnumerable<Anime>)> GetList(FiltersRequest filters)
    {
        var query = GetBaseQuery();

        if (filters.BrandIds != null && filters.BrandIds.Count != 0)
            query = query.Where(x => x.Brands.Any(y => filters.BrandIds.Contains(y.BrandId)));

        if (filters.TagIds != null && filters.TagIds.Count != 0)
            query = query.Where(x => x.Tags.Any(y => filters.TagIds.Contains(y.TagId)));

        if (!string.IsNullOrWhiteSpace(filters.Title))
            query = query.Where(x => x.Title.ToLower().Contains(filters.Title.ToLower()));

        var totalCount = await query.CountAsync();

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
        var count = await _context.Animes.CountAsync();
        var randomIndex = new Random().Next(count);
        return await query.Skip(randomIndex).FirstAsync();
    }

    public async Task<IEnumerable<string>> GetTitles()
    {
        return await _context.Animes
            .Select(x => x.Title)
            .Distinct()
            .ToListAsync();
    }

    public async Task<Anime> Add(Anime anime)
    {
        foreach (var brand in anime.Brands)
            _context.Entry(brand).State = EntityState.Unchanged;

        foreach (var tag in anime.Tags)
            _context.Entry(tag).State = EntityState.Unchanged;

        anime.CreatedDate = DateTime.Now;
        _context.Animes.Add(anime);

        await _context.SaveChangesAsync();
        return anime;
    }

    public async Task<Anime> Update(int animeId, Anime anime)
    {
        var existingAnime = await _context.Animes
            .Include(x => x.Brands)
            .Include(x => x.Tags)
            .FirstAsync(x => x.AnimeId == animeId);

        anime.AnimeId = animeId;
        anime.UpdatedDate = DateTime.Now;
        _context.Entry(existingAnime).CurrentValues.SetValues(anime);

        existingAnime.Brands.Clear();
        foreach (var brand in anime.Brands)
            existingAnime.Brands.Add(brand);

        existingAnime.Tags.Clear();
        foreach (var tag in anime.Tags)
            existingAnime.Tags.Add(tag);

        await _context.SaveChangesAsync();
        return anime;
    }

    private IQueryable<Anime> GetBaseQuery()
    {
        return _context.Animes
            .Include(x => x.Brands)
            .Include(x => x.Tags)
            .OrderBy(x => x.Folder)
            .ThenBy(x => x.ChapterNumber);
    }
}

public interface IAnimeRepository
{
    public Task<(int totalCount, IEnumerable<Anime>)> GetList(FiltersRequest filters);
    public Task<Anime> Get(int animeKey);
    Task<Anime> GetRandom();
    Task<IEnumerable<string>> GetTitles();
    Task<Anime> Add(Anime anime);
    Task<Anime> Update(int animeId, Anime anime);
}