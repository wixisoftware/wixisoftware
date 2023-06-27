using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wixisoftware.Entities.Concrete
{
    public class Blog
    {

        [Key]
        public int BlogID { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogContent { get; set; }
        public DateTime BlogCratedDate { get; set; }
        public string? BlogThumbnailImage { get; set; }
        public string? BlogImage { get; set; } = "";
        public bool BlogStatus { get; set; }



        // Artık ilişkili bir yapıları mevcut
        public int CategoryID { get; set; }
        public Category Category { get; set; }


        public List<Comment> Comments { get; set; }



    }
}
