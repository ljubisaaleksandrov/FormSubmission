using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FormSubmission.Services
{
    public class CommentsService
    {
        public List<Comment> Comments { get; set; }

        public CommentsService()
        {
            Comments = new List<Comment>();

            Comments.Add(new Comment()
            {
                Email = "test1@test.com",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pulvinar vel augue sed vehicula. Sed sit amet risus pretium, aliquam risus ut, finibus nisi.",
                DateSubmitted = DateTime.Now.AddMinutes(-5)
            });
            Comments.Add(new Comment()
            {
                Email = "test2@test.com",
                Text = "Aenean pulvinar vel augue sed vehicula. Sed sit amet risus pretium, aliquam risus ut, finibus nisi.",
                DateSubmitted = DateTime.Now.AddMinutes(-10)
            });
            Comments.Add(new Comment()
            {
                Email = "test3@test.com",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Sed sit amet risus pretium, aliquam risus ut, finibus nisi.",
                DateSubmitted = DateTime.Now.AddMinutes(-15)
            });
        }

        public List<Comment> GetComments()
        {
            return Comments.OrderByDescending(c => c.DateSubmitted).ToList();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
    }
}