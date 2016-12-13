using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dlrealestate3.Models
{
    public class LocalHistory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string KeyWord { get; set; }
        public DateTime DatePublished { get; set; }
    }
}