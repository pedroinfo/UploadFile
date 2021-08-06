using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using MvcUploadToMongoDB.Models;

namespace MvcUploadToMongoDB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMongoClient _mongoClient;
        private readonly IGridFSBucket _gridFsBucket;

        private readonly IConfiguration _configuration;

        public ProductsController(IMongoClient mongoClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _mongoClient = mongoClient;
            var database = mongoClient.GetDatabase(_configuration.GetSection("MongoDBName").Value);

            _productCollection = database.GetCollection<Product>("product");

            _gridFsBucket = new GridFSBucket(database);
        }
        public ActionResult Index()
        {
            var list = _productCollection.AsQueryable().ToList();

            return View(list);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

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

        public ActionResult Delete(int id)
        {
            return View();
        }

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
