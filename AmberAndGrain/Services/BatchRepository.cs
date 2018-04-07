using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AmberAndGrain.Models;
using Dapper;

namespace AmberAndGrain.Services
{
    public class BatchRepository
    {
        public bool Create(int recipeId, string cooker)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["AmberAndGrain"].ConnectionString))
            {
                db.Open();
                var batchesCreated = db.Execute(@"INSERT INTO Batches (RecipeId, Cooker)
                             VALUES (@recipeId, @cooker)", new {recipeId,cooker});

                return batchesCreated == 1;
            }
        }

        public Batch Get(int batchId)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["AmberAndGrain"].ConnectionString))
            {
                db.Open();
                var getSingleBatch = db.QueryFirst<Batch>(@"SELECT * FROM Batches WHERE Id = @batchId", batchId);

                return getSingleBatch;
            }
        }
    }

    public class Batch
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateBarrelled { get; set; }
        public int? NumberOfBarrels { get; set; }
        public DateTime? DateBottled { get; set; }
        public int? NumberOfBottles { get; set; }
        public string Cooker { get; set; }
        public double? PricePerBottle { get; set; }
        public int? NumberOfBottlesLeft { get; set; }
        public BatchStatus Status { get; set; }
    }
}