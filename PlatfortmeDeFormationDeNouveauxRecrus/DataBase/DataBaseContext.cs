using Microsoft.EntityFrameworkCore;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.EnableSensitiveDataLogging();

        public DbSet<Role> Roles { get; set; } 
        public DbSet<User> Users { get; set; }
        public  DbSet<Departement> Departements { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<SousDepartement> SousDepartements { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<PlanFormation> PlanFormations { get; set; }
        public DbSet<Reclamation> Reclamations { get; set; }
        public DbSet<Salle> Salles { get; set; }
        public DbSet<Bureau> Bureaus { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Create default roles with migration
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Name = "Admin",

                },
                new Role()
                {
                    Id = 2,
                    Name = "Manager",

                },
                 new Role()
                 {
                     Id = 3,
                     Name = "Formatteur",

                 }
                 ,
                 new Role()
                 {
                     Id = 4,
                     Name = "Participant",

                 }
            );

            modelBuilder.Entity<User>().HasMany<Role>(s => s.Roles).WithMany(r => r.Users);
           // modelBuilder.Entity<Departement>().HasMany(u => u.Users).WithOne(e => e.Departement);
           // modelBuilder.Entity<Project>().HasMany(p => p.Documents).WithOne(d => d.Project).IsRequired(false);
            modelBuilder.Entity<Departement>().HasMany(s => s.SousDepartements).WithOne(s => s.Departement);
           // modelBuilder.Entity<User>().HasMany(s => s.Reclamations).WithOne(s => s.Users);
            //modelBuilder.Entity<Departement>().HasMany(s => s.Projects).WithOne(s => s.Departement);

        }


    }
}
