using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());


        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommmentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            //p.DestinationID = 3;
            commentManager.TAdd(p);
            return RedirectToAction("Index", "Destination");
        }




        //[HttpGet]
        //public PartialViewResult   AddComment()
        //{
        //     return PartialView();
        //}
        //[HttpPost]
        //public PartialViewResult AddComment(Comment p)
        //{
        //    p.CommmentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.CommmentState = true;
        //    commentManager.TAdd(p);
        //    return PartialView();
        //}
    }
}
