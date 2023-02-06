using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Readings")]
    public class Reading
    {
        [Required]
        [ForeignKey("Buildings")]
        public Int16 BuildingId { get; set; }
        [Required]
        [ForeignKey("Objects")]
        public sbyte ObjectId { get; set; }
        [Required]
        [ForeignKey("DataFields")]
        public sbyte DataFieldId { get; set; }
        [Column(TypeName = "decimal")]
        public decimal Value { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
