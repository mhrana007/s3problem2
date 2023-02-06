using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("DataFields")]
    public class DataField
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
