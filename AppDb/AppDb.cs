using System;
using Microsoft.EntityFrameworkCore;
using ProfessionalGYM.Models.Entity.GymClass;
using ProfessionalGYM.Models.Entity.MemberShip;
using ProfessionalGYM.Models.Entity.MemberShipType;
using ProfessionalGYM.Models.Entity.NutritionPlan;
using ProfessionalGYM.Models.Entity.Payment;
using ProfessionalGYM.Models.Entity.ProfessionalTrainer;
using ProfessionalGYM.Models.Entity.RoleModel;
using ProfessionalGYM.Models.Entity.UserEntity;
using ProfessionalGYM.Models.Entity.Workout;

namespace ProfessionalGYM.AppDb
{
    public class AppDb : DbContext
    {

        public AppDb(DbContextOptions<AppDb> options)
        : base(options)
        {

        }
        public DbSet<User> UsersDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<MemberShip> MembershipTypes { get; set; }
        public DbSet<GymClass> GymClasses { get; set; }
        public DbSet<ProfesionalTrainer> ProfesionalTrainers { get; set; }
        public DbSet<WorkOut> Workouts { get; set; }
        public DbSet<NutritionPlan> NutritionPlans { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
