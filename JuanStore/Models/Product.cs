using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JuanStore.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        
        public int DiscountPrice { get; set; }
        [Required, StringLength(maximumLength: 1000)]
        public string Description { get; set; }
        public bool IsTopSeller { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
