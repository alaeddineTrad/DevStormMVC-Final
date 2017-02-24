using DevStormMvc.Data.Infrastructure;
using DevStormMvc.Models;
using Domain.Entities;
using ServicesSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevStormMvc.Controllers
{
    public class RateReviewController : Controller
    {
        IServiceRateReview serviceRateReview = new ServiceRateReview();
        // GET: RateReview
        public ActionResult Index()
        {
            return View();
        }

        // GET: RateReview/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RateReview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RateReview/Create
        [HttpPost]
        public ActionResult Create(RateReviewModel RRM)
        {
            RateReview rr = new RateReview

            {
                RateReviewId = RRM.ratereviewId,
                Mark = RRM.mark


            };
            try
            {
                // TODO: Add insert logic here

                //DatabaseFactory dbf = new DatabaseFactory();
                //UnitOfWork u = new UnitOfWork(dbf);
                //u.GetRepository<RateReview>().Add(rr);
                //u.Commit();
                serviceRateReview.Add(rr);
                serviceRateReview.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RateReview/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RateReview/Edit/5
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

        // GET: RateReview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RateReview/Delete/5
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
