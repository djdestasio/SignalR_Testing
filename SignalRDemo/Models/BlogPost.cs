using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalRDemo.Models {
    public class BlogPost {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Article")]
        [DataType(DataType.MultilineText)]
        public string BlogBody { get; set; }
    }
}