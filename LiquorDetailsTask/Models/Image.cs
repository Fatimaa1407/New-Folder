using LiquorDetailsTask.Models;

namespace LiquorDetailsTask.Models
{
    public class Images : BaseEntity
    {
        public string Url { get; set; }
        public bool IsPrimary { get; set; } = false;
        public Product Product { get; set; }
    }
}
