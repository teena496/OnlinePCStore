using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlinePCStore.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public int UserId { get; set; }
  
        public int Item1 { get; set; }

        public int Item2 { get; set; }

        public int Item3 { get; set; }

    }
}