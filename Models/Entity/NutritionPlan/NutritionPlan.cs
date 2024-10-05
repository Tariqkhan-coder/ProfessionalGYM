using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProfessionalGYM.Models.Entity.NutritionPlan
{
    public class NutritionPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Meal { get; set; } = "";
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Macronutrients { get; set; } = "";
        public DateTime PlanDate { get; set; }

    }
}
