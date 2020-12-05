using FormSubmission.Models;
using FormSubmission.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class CommentsController : Controller
    {
        private readonly CommentsService _commentsService;
        public CommentsController()
        {
            _commentsService = new CommentsService();
        }

        public ActionResult Index()
        {
            List<Comment> model = _commentsService.GetComments();
            return View(model);
        }

        [HttpPost]
        public ActionResult SudmitComment(Comment comment)
        {
            comment.DateSubmitted = DateTime.Now;
            _commentsService.AddComment(comment);

            List<Comment> model = _commentsService.GetComments();
            return View("Index", model);
        }
    }
}