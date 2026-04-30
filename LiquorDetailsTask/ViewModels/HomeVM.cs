using LiquorDetailsTask.Models;

namespace LiquorDetailsTask.ViewModels

{
    public class HomeVM
    {
        public List<Product> Products { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Images> Images { get; set; }
    }
}
