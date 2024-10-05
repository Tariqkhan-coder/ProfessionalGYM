using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProfessionalGYM.Models.Entity.Workout
{
    public class WorkOut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(450)]
        public string Exercise { get; set; } = "";
        public int Set {  get; set; }
        public int Reps {  get; set; }
        public decimal Weight { get; set; }
        public DateTime WorkoutDate { get; set; }
    }
}
