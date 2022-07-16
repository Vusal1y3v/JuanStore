using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuanStore.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(maximumLength:255)]
        public string Image { get; set; }
        [Required, StringLength(maximumLength:1200)]
        public string Description { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string MainTitel { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string SubTitel { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string RedirectUrl { get; set; }
        public bool isMainSlider { get; set; }
        public bool isProductSlider { get; set; }

    }
}
