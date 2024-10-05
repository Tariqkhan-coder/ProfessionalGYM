using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProfessionalGYM.Models.Entity.RoleModel
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long  RoleId { get; set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(200)]
        public string RoleName { get; set; } = "";  //Admin,Member,Tranier

    }
}
