using MongoDB.Bson;
using System.Collections.Generic;

namespace MvcUploadToMongoDB.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; } 

        public IList<ProductImage> ProductImages { get; set; }
    }
}
