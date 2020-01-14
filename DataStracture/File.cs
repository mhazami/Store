using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataStracture
{
    [Table("File", Schema = "FileManager")]
    public class File
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(10)]
        public string Extention { get; set; }

        public int Size { get; set; }

        public byte[] Content { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string ContentType { get; set; }

    }
}
