using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStracture
{
    public class FooterSlider
    {
        [Key]
        public int Id { get; set; }
        public byte Order { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        public Guid FileId { get; set; }
    }
}
