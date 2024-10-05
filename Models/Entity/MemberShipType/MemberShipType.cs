using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProfessionalGYM.Models.Entity.MemberShipType
{
    public class MemberShipType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string MemberShipName { get; set; } = "";   //Monthly,Yearly

        public int Price {  get; set; }
    }
}
