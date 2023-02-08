using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Readings")]
    public class Reading
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        [Required]
        [ForeignKey("Buildings")]
        public Int16 BuildingId { get; set; }
        [Required]
        [ForeignKey("Objects")]
        public sbyte ObjectId { get; set; }
        [Required]
        [ForeignKey("DataFields")]
        public sbyte DataFieldId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
    }
}
