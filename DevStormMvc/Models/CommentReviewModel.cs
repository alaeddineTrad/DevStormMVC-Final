using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevStormMvc.Models
{
    public class CommentReviewModel : ReviewModel
    {
        public int commentreviewId { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }
    }
}