using DataStracture;
using System.Data.Entity;

namespace Store.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("name=StoreConnection") { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FooterSlider> FooterSliders { get; set; }

    }
}