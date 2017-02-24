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
    public class CommentReviewController : Controller
    {
        IServiceCommentReview serviceCommentReview = new ServiceCommentReview();
        // GET: CommentReview
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommentReview/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommentReview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentReview/Create
        [HttpPost]
        public ActionResult Create(CommentReviewModel CRM)
        {
            CommentReview cr = new CommentReview
            {
                CommentReviewId = CRM.commentreviewId,
                Date = CRM.date,
                Text = CRM.text
            };
            try
            {
                // TODO: Add insert logic here

                //DatabaseFactory dbf = new DatabaseFactory();
                //UnitOfWork u = new UnitOfWork(dbf);
                //u.GetRepository<CommentReview>().Add(cr);
                //u.Commit();
                serviceCommentReview.Add(cr);
                serviceCommentReview.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentReview/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommentReview/Edit/5
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

        // GET: CommentReview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommentReview/Delete/5
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
