using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    /// <summary>
    /// User Comments Model
    /// </summary>
    public class Comment
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Text { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd hh:mm}")]
        public DateTime DateSubmitted { get; set; }
    }
}