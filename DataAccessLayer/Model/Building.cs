using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Buildings")]
    public class Building
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
