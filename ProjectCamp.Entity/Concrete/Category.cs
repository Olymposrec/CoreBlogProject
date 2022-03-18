using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCamp.Entity.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string MyProperty { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Blog> Blogs{ get; set; }

    }
}
