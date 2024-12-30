﻿using MediaVisualizer.DataAccess.Entities.Anime;
using MediaVisualizer.DataAccess.Entities.Manga;
using MediaVisualizer.DataAccess.Entities.Manwha;
using MediaVisualizer.DataAccess.Entities.Shared;
using Microsoft.EntityFrameworkCore;

namespace MediaVisualizer.DataAccess;

public class MediaVisualizerDbContext : DbContext
{
    public MediaVisualizerDbContext(DbContextOptions<MediaVisualizerDbContext> options) : base(options)
    {
    }

    public DbSet<Anime> Animes { get; set; }
    public DbSet<AnimeChapter> AnimeChapters { get; set; }
    public DbSet<Manga> Mangas { get; set; }
    public DbSet<MangaChapter> MangaChapters { get; set; }
    public DbSet<Manwha> Manwhas { get; set; }
    public DbSet<ManwhaChapter> ManwhaChapters { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Tag> Tags { get; set; }
}