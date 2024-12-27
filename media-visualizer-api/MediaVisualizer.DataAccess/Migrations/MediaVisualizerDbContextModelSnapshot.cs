﻿// <auto-generated />
using System;
using MediaVisualizer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediaVisualizer.DataAccess.Migrations
{
    [DbContext(typeof(MediaVisualizerDbContext))]
    partial class MediaVisualizerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.Anime", b =>
                {
                    b.Property<int>("AnimeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Folder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeKey");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.AnimeBrand", b =>
                {
                    b.Property<int>("AnimeKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeKey", "BrandKey");

                    b.HasIndex("BrandKey");

                    b.ToTable("AnimeBrand");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.AnimeChapter", b =>
                {
                    b.Property<int>("AnimeChapterKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChapterNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeChapterKey");

                    b.HasIndex("AnimeKey");

                    b.ToTable("AnimeChapter");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.AnimeTag", b =>
                {
                    b.Property<int>("AnimeKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeKey", "TagKey");

                    b.HasIndex("TagKey");

                    b.ToTable("AnimeTag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.Manga", b =>
                {
                    b.Property<int>("MangaKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Folder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MangaKey");

                    b.ToTable("Manga");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaArtist", b =>
                {
                    b.Property<int>("MangaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MangaKey", "ArtistKey");

                    b.HasIndex("ArtistKey");

                    b.ToTable("MangaArtist");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaAuthor", b =>
                {
                    b.Property<int>("MangaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MangaKey", "AuthorKey");

                    b.HasIndex("AuthorKey");

                    b.ToTable("MangaAuthor");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaBrand", b =>
                {
                    b.Property<int>("MangaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MangaKey", "BrandKey");

                    b.HasIndex("BrandKey");

                    b.ToTable("MangaBrand");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaChapter", b =>
                {
                    b.Property<int>("MangaChapterKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChapterNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MangaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PagesCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MangaChapterKey");

                    b.HasIndex("MangaKey");

                    b.ToTable("MangaChapter");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaTag", b =>
                {
                    b.Property<int>("MangaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MangaKey", "TagKey");

                    b.HasIndex("TagKey");

                    b.ToTable("MangaTag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", b =>
                {
                    b.Property<int>("ManwhaKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Folder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ManwhaKey");

                    b.ToTable("Manwha");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaArtist", b =>
                {
                    b.Property<int>("ManwhaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ManwhaKey", "ArtistKey");

                    b.HasIndex("ArtistKey");

                    b.ToTable("ManwhaArtist");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaAuthor", b =>
                {
                    b.Property<int>("ManwhaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ManwhaKey", "AuthorKey");

                    b.HasIndex("AuthorKey");

                    b.ToTable("ManwhaAuthor");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaBrand", b =>
                {
                    b.Property<int>("ManwhaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ManwhaKey", "BrandKey");

                    b.HasIndex("BrandKey");

                    b.ToTable("ManwhaBrand");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaChapter", b =>
                {
                    b.Property<int>("ManwhaChapterKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChapterNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ManwhaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PagesCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ManwhaChapterKey");

                    b.HasIndex("ManwhaKey");

                    b.ToTable("ManwhaChapter");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaTag", b =>
                {
                    b.Property<int>("ManwhaKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagKey")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ManwhaKey", "TagKey");

                    b.HasIndex("TagKey");

                    b.ToTable("ManwhaTag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Shared.Artist", b =>
                {
                    b.Property<int>("ArtistKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistKey");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Shared.Author", b =>
                {
                    b.Property<int>("AuthorKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorKey");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Shared.Brand", b =>
                {
                    b.Property<int>("BrandKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("BrandKey");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Shared.Tag", b =>
                {
                    b.Property<int>("TagKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("TagKey");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.AnimeBrand", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Anime.Anime", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.AnimeChapter", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Anime.Anime", "Anime")
                        .WithMany("AnimeChapters")
                        .HasForeignKey("AnimeKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.AnimeTag", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Anime.Anime", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaArtist", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manga.Manga", "Manga")
                        .WithMany()
                        .HasForeignKey("MangaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Manga");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaAuthor", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manga.Manga", "Manga")
                        .WithMany()
                        .HasForeignKey("MangaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Manga");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaBrand", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manga.Manga", "Manga")
                        .WithMany()
                        .HasForeignKey("MangaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Manga");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaChapter", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manga.Manga", "Manga")
                        .WithMany("MangaChapters")
                        .HasForeignKey("MangaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manga");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.MangaTag", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manga.Manga", "Manga")
                        .WithMany()
                        .HasForeignKey("MangaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manga");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaArtist", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", "Manwha")
                        .WithMany()
                        .HasForeignKey("ManwhaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Manwha");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaAuthor", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", "Manwha")
                        .WithMany()
                        .HasForeignKey("ManwhaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Manwha");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaBrand", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", "Manwha")
                        .WithMany()
                        .HasForeignKey("ManwhaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Manwha");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaChapter", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", "Manwha")
                        .WithMany("ManwhaChapters")
                        .HasForeignKey("ManwhaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manwha");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.ManwhaTag", b =>
                {
                    b.HasOne("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", "Manwha")
                        .WithMany()
                        .HasForeignKey("ManwhaKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaVisualizer.DataAccess.Entities.Shared.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manwha");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Anime.Anime", b =>
                {
                    b.Navigation("AnimeChapters");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manga.Manga", b =>
                {
                    b.Navigation("MangaChapters");
                });

            modelBuilder.Entity("MediaVisualizer.DataAccess.Entities.Manwha.Manwha", b =>
                {
                    b.Navigation("ManwhaChapters");
                });
#pragma warning restore 612, 618
        }
    }
}
