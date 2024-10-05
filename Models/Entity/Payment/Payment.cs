using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProfessionalGYM.Models.Entity.UserEntity;

namespace ProfessionalGYM.Models.Entity.Payment
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
       
        public decimal Amount { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string PaymentMethod { get; set; } = "";
        public DateTime PaymentDate { get; set; }
    }
}
