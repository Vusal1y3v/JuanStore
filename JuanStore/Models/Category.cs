using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuanStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,StringLength(maximumLength:255)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
