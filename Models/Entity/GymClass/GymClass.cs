using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProfessionalGYM.Models.Entity.UserEntity;

namespace ProfessionalGYM.Models.Entity.GymClass
{
    public class GymClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Name { get; set; } = "";
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Description { get; set; } = "";
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Schedule { get; set; } = "";

        public int Capacity { get; set; }


    }
}
