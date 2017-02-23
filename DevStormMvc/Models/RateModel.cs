using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevStormMvc.Models
{
    public class RateModel : InteractionModel
    {
        public int rateId { get; set; }
        public int mark { get; set; }
    }
}