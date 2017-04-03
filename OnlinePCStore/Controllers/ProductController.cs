using OnlinePCStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlinePCStore.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _context;


        public ProductController()
        {
            _context = new ApplicationDbContext();

        }
        protected new void Dispose()
     
        {
            _context.Dispose();
        }
        // GET: Product
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index","Product");
        }

        public ActionResult AddProduct()
        {
            return View("AddProduct");
        }
        public ActionResult SingleProduct(int Id)
        {
            var products = _context.Products.Where(m => m.Id == Id).ToList();
            return View(products);
        }
        
        public ActionResult Index()
        {
            return View("AddProduct");
        }
     
        //public ActionResult Cart(int PId, int CId)
        //{
        //    var customerInDb
        //    _context.Products.;
        //    _context.SaveChanges();
        //    return View();
        //}

    }
}