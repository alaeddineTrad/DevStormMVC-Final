﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevStormMvc.Models
{
    public class RateReviewModel : ReviewModel
    {
        public int ratereviewId { get; set; }
        public int mark { get; set; }
    }
}