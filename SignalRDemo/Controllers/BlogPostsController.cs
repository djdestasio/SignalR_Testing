using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRDemo.Models;
using SignalRDemo;

namespace SignalRDemo.Controllers
{ 
    public class BlogPostsController : Controller
    {
        private BlogPostContext db = new BlogPostContext();

        //
        // GET: /BlogPosts/

        public ViewResult Index()
        {
            return View(db.BlogPosts.ToList());
        }

        //
        // GET: /BlogPosts/Details/5

        public ViewResult Details(int id)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            return View(blogpost);
        }

        //
        // GET: /BlogPosts/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /BlogPosts/Create

        [HttpPost]
        public ActionResult Create(BlogPost blogpost)
        {
            if (ModelState.IsValid)
            {
                db.BlogPosts.Add(blogpost);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(blogpost);
        }
        
        //
        // GET: /BlogPosts/Edit/5
 
        public ActionResult Edit(int id)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            return View(blogpost);
        }

        //
        // POST: /BlogPosts/Edit/5

        [HttpPost]
        public ActionResult Edit(BlogPost blogpost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogpost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogpost);
        }

        //
        // GET: /BlogPosts/Review/5

        public ActionResult Review(int id) {
            BlogPost blogpost = db.BlogPosts.Find(id);
            return View(blogpost);
        }

        //
        // POST: /BlogPosts/Review/5

        [HttpPost]
        public ActionResult Review(BlogPost blogpost) {
            if (ModelState.IsValid) {
                db.Entry(blogpost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogpost);
        }

        //
        // GET: /BlogPosts/Delete/5
 
        public ActionResult Delete(int id)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            return View(blogpost);
        }

        //
        // POST: /BlogPosts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            BlogPost blogpost = db.BlogPosts.Find(id);
            db.BlogPosts.Remove(blogpost);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}