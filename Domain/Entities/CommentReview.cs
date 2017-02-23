using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CommentReview : Review
    {
        private int commentreviewId;
        private DateTime date;
        private string text;

        public CommentReview() : base()
        {

        }

        public int CommentReviewId
        {
            get
            {
                return commentreviewId;
            }

            set
            {
                commentreviewId = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}
