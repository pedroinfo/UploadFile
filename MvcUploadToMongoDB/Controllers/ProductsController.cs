using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using MvcUploadToMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUploadToMongoDB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMongoClient _mongoClient;
        private readonly GridFSBucket gridFS;

        private readonly IConfiguration _configuration;

        public ProductsController(IMongoClient mongoClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _mongoClient = mongoClient;
            var database = mongoClient.GetDatabase(_configuration.GetSection("MongoDBName").Value);
            gridFS = new GridFSBucket(database);
        }
        public ActionResult Index()
        {
           // var file = System.IO.File.ReadAllBytes(@"D:\file.zip");
         //   gridFS.UploadFromBytes("file.zip", file);

            return View();
        }

        // GET: ProductsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
