using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuanStore.Models;
namespace JuanStore.ViewModels.Home
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Setting> settings { get; set; }
    }
}
