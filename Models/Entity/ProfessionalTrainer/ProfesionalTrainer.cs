using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProfessionalGYM.Models.Entity.ProfessionalTrainer
{
    public class ProfesionalTrainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Name { get; set; } = "";
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Bio { get; set; } = "";
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Schedule { get; set; } = "";
    }
}
