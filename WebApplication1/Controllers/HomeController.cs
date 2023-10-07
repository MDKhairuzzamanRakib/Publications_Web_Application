using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        ArticleDbContext db = new ArticleDbContext();

        public ActionResult Index()
        {
            var viewModelData = db.Articles.AsEnumerable().Select(a => new ArticleViewModel
            {
                ArticleId = a.ArticleId,
                Title = a.Title,
                PublishDate = a.PublishDate,
                Tags=string.Join(", ",a.ArticleTags.Select(t=>t.Tag.TagName).ToArray())
            });
            return View(viewModelData);
        }

        public ActionResult Create()
        {
            ViewBag.checkBoxData=db.Tags.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}