﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipesVersion2.Data;

namespace RecipesVersion2.Migrations
{
    [DbContext(typeof(RecipesVersion2Context))]
    partial class RecipesVersion2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("RecipesVersion2.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Cuisine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CuisineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cuisine");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IngredientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("InstructionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Order")
                        .HasColumnType("real");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Instruction");
                });

            modelBuilder.Entity("RecipesVersion2.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("InstructionId")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int?>("RecipeIngredientNameId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipesId")
                        .HasColumnType("int");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstructionId");

                    b.HasIndex("RecipeIngredientNameId");

                    b.HasIndex("RecipesId");

                    b.HasIndex("UnitId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("RecipeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("CuisineId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IngredientId")
                        .HasColumnType("int");

                    b.Property<bool>("Metric")
                        .HasColumnType("bit");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Instruction", b =>
                {
                    b.HasOne("RecipesVersion2.Models.Recipes", "Recipe")
                        .WithMany("Instruction")
                        .HasForeignKey("RecipeId");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipesVersion2.Models.RecipeIngredient", b =>
                {
                    b.HasOne("RecipesVersion2.Models.Instruction", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("InstructionId");

                    b.HasOne("RecipesVersion2.Models.Ingredient", "RecipeIngredientName")
                        .WithMany()
                        .HasForeignKey("RecipeIngredientNameId");

                    b.HasOne("RecipesVersion2.Models.Recipes", null)
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipesId");

                    b.HasOne("RecipesVersion2.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");

                    b.Navigation("RecipeIngredientName");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Recipes", b =>
                {
                    b.HasOne("RecipesVersion2.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("RecipesVersion2.Models.Cuisine", "Cuisine")
                        .WithMany()
                        .HasForeignKey("CuisineId");

                    b.Navigation("Course");

                    b.Navigation("Cuisine");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Unit", b =>
                {
                    b.HasOne("RecipesVersion2.Models.Ingredient", null)
                        .WithMany("Units")
                        .HasForeignKey("IngredientId");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Ingredient", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Instruction", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("RecipesVersion2.Models.Recipes", b =>
                {
                    b.Navigation("Instruction");

                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
