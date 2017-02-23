using Data;
using DevStormMvc.Data.Infrastructure;
using DevStormMvc.Models;
using Domain.Entities;
using Domain.Entities.ComplexType;
using ServicesSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevStormMvc.Controllers
{
    public class ProductController : Controller
    {

        //IServiceProduct serviceProduct = new ServiceProduct();
        
        // GET: Product
        public ActionResult Index(ImageModel)
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel PM)
        {
            Context ctx = new Context(); 
            Category c = new Category { Name = "Test" };
            
            //List<Image> im = new List<Image>();
            //foreach (var x in PM.Images) {
            //    Image i = new Image ();
            //    i.ImageId = x ;
            //    ctx.Images.Attach(i);
            //    im.Add(i);
                

            //}
             
            Product p = new Product

            {
                ProductId = PM.productId,
                Name = PM.name,
                Brand = PM.brand,
                Discount = PM.discount,
                Tva = PM.tva,
                Price = PM.price,
                Quantity = PM.quantity,
                Category = c,
                //Images = im
               

            };
            
            try
            {
                // TODO: Add insert logic here
                //serviceProduct.Add(p);
                //serviceProduct.Commit();
                DatabaseFactory dbf = new DatabaseFactory();
                UnitOfWork u = new UnitOfWork(dbf);
                u.GetRepository<Product>().Add(p);
                u.Commit();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
