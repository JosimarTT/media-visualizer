﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MediaVisualizer.DataAccess.Entities.Shared;

namespace MediaVisualizer.DataAccess.Entities.Anime;

public class Anime : AuditEntity
{
    [Key] public int AnimeId { get; set; }

    public string Folder { get; set; }

    public string Title { get; set; }

    public int ChapterNumber { get; set; }

    public string Logo { get; set; }

    public string Video { get; set; }

    public ICollection<Brand> Brands { get; set; } = new List<Brand>();

    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}