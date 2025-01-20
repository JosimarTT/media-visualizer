﻿using System.ComponentModel.DataAnnotations;

namespace MediaVisualizer.DataAccess.Entities;

public class Tag : AuditEntity
{
    [Key] public int TagId { get; set; }

    public string Name { get; set; }

    public ICollection<Anime> Animes { get; set; } = new List<Anime>();

    public ICollection<Manga> Mangas { get; set; } = new List<Manga>();

    public ICollection<Manwha> Manwhas { get; set; } = new List<Manwha>();
}