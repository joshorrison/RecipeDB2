namespace RecipeDB2.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class RecipeModels : DbContext
    {
        // Your context has been configured to use a 'RecipeModels' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RecipeDB2.Models.RecipeModels' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RecipeModels' 
        // connection string in the application configuration file.
        public RecipeModels()
            : base("name=RecipeModels.cs")
        {
        }

        public System.Data.Entity.DbSet<RecipeDB2.Models.Recipe> Recipes { get; set; }

        public System.Data.Entity.DbSet<RecipeDB2.Models.Ingredient> Ingredients { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        [Required]
        public string Name { get; set; }

        public string Directions { get; set; }

        public string Author { get; set; }

        public int SourceId { get; set; }
        
        public ICollection<Ingredient> Ingredients { get; set; }
    }

    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Unit of Measure")]
        public string UOM { get;set; }

        [Required]
        [Range(minimum: 0, maximum: 100, ErrorMessage = "Value must be between 0 and 100.")]
        public double Amount { get; set; }
    }
}