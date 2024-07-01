﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Projeto_CodeDeveloper_24.Migrations
{
    [DbContext(typeof(ProjetoDbContext))]
    [Migration("20240628163244_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Projeto_CodeDeveloper_24.Models.Ingredientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IngredienteName")
                        .HasColumnType("TEXT");

                    b.Property<int>("IngredientesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Projeto_CodeDeveloper_24.Models.ReceitaIngredientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IngredientesId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Quantidade")
                        .HasColumnType("REAL");

                    b.Property<string>("Unidades")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IngredientesId");

                    b.ToTable("ReceitaIngredientes");
                });

            modelBuilder.Entity("Projeto_CodeDeveloper_24.Models.Receitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dificuldade")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Duracao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("ReceitaIngredientesReceitas", b =>
                {
                    b.Property<int>("ReceitaIngredientesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReceitasId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReceitaIngredientesId", "ReceitasId");

                    b.HasIndex("ReceitasId");

                    b.ToTable("ReceitaIngredientesReceitas");
                });

            modelBuilder.Entity("Projeto_CodeDeveloper_24.Models.ReceitaIngredientes", b =>
                {
                    b.HasOne("Projeto_CodeDeveloper_24.Models.Ingredientes", "Ingredientes")
                        .WithMany("ReceitaIngredientes")
                        .HasForeignKey("IngredientesId");

                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("ReceitaIngredientesReceitas", b =>
                {
                    b.HasOne("Projeto_CodeDeveloper_24.Models.ReceitaIngredientes", null)
                        .WithMany()
                        .HasForeignKey("ReceitaIngredientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projeto_CodeDeveloper_24.Models.Receitas", null)
                        .WithMany()
                        .HasForeignKey("ReceitasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projeto_CodeDeveloper_24.Models.Ingredientes", b =>
                {
                    b.Navigation("ReceitaIngredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
