using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstApp1399.Services;
using MyFirstApp1399.Models;


namespace MyFirstApp1399.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        Comment_Srv cmm = new Comment_Srv();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReadComments()
        {
            List<Comment> lstCmm = cmm.Read_Comment();
            return View("CrudComment",lstCmm);
        }

        public void UpdateComments(Comment cmmEntity)
        {
            cmm.Update_Comment(cmmEntity);

        }

        public ActionResult InsertComments()
        {
            return View("InsertComment" );

        }

        [HttpPost]
        public ActionResult CreateComments(Comment cmmEntity)
        {
            cmm.Create_Comment(cmmEntity);
            List<Comment> lstCmm = cmm.Read_Comment();
            return View("CrudComment", lstCmm);
        }

        [HttpPost]
        public ActionResult RemoveComments(int id)
        {
            cmm.Remove_Comment(id);

            //bargadeh be ReadComment
            List<Comment> lstCmm = cmm.Read_Comment();
            return View("CrudComment", lstCmm);

        }
    }
}