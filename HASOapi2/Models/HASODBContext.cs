using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models
{
    public class HASODBContext : DbContext
    {
        public HASODBContext(DbContextOptions options)
              : base(options)
        {
        }

        public virtual DbSet<Classe> Classe { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Uploadedfile> Uploadedfile { get; set; }
        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Listeatt> Listeatt { get; set; }
        public virtual DbSet<Listefinal> Listefinal { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Listeatt>().HasData(
                new Listeatt { Id=1,idc=1,ide=3,name= "Student 1" }
                , new Listeatt { Id = 2, idc = 1, ide = 4, name = "Student 2" });


            modelBuilder.Entity<User>().HasData(
                new User{ Id = 1, Name = "Professor 1", Email= "prof1@bla.com", Login= "prof1", Password= "123", Phone= "0123456789", Role= "Professor"}
       , new User { Id = 2, Name = "Professor 2", Email = "prof2@bla.com", Login = "prof2", Password = "123", Phone = "0123456789", Role = "Professor" }
       , new User { Id = 3, Name = "Student 1", Email = "stud1@bla.com", Login = "stud1", Password = "123", Phone = "0123456789", Role = "Student" }
       , new User { Id = 4, Name = "Student 2", Email = "stud2@bla.com", Login = "stud2", Password = "123", Phone = "0123456789", Role = "Student" }
       , new User { Id = 5, Name = "Student 3", Email = "stud3@bla.com", Login = "stud3", Password = "123", Phone = "0123456789", Role = "Student" }
          );
            modelBuilder.Entity<Classe>().HasData(
                new Classe {Id=1, Name= "MATHEMATICS", IdProf = 1, Description= "this is specially made to be able to share with your math teacher"}
                , new Classe { Id = 2, Name = "PHYSICS", IdProf = 1, Description = "this is specially made to be able to share with your PHYSICS teacher" }
                , new Classe { Id = 3, Name = "CHEMISTRY", IdProf = 1, Description = "this is specially made to be able to share with your CHEMISTRY teacher" }
                , new Classe { Id = 4, Name = "FRENSH", IdProf = 2, Description = "this is specially made to be able to share with your FRENSH teacher" }
                , new Classe { Id = 5, Name = "ENGLISH", IdProf = 2, Description = "this is specially made to be able to share with your ENGLISH teacher" }
                );
            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, Date = new DateTime(), IdPublication= 1, IdUser= 1, Contenus="first comment" }
                );
            modelBuilder.Entity<Publication>().HasData(
                new Publication { Id = 1, Date = new DateTime(), IdUser = 1, IdClasse = 1, Contenus = "this is the first publication." }
                ,new Publication { Id = 2, Date = new DateTime(), IdUser = 1, IdClasse = 1, Contenus = "this is the second publication." }
               , new Publication { Id = 3, Date = new DateTime(), IdUser = 2, IdClasse = 1, Contenus = "this is the third publication." }
               , new Publication { Id = 4, Date = new DateTime(), IdUser = 3, IdClasse = 2, Contenus = "this is the fourth publication." }
               , new Publication { Id = 5, Date = new DateTime(), IdUser = 3, IdClasse = 3, Contenus = "this is the fifth publication." }
               , new Publication { Id = 6, Date = new DateTime(), IdUser = 3, IdClasse = 4, Contenus = "this is the sixth publication." }
               , new Publication { Id = 7, Date = new DateTime(), IdUser = 1, IdClasse = 5, Contenus = "this is the seventh publication." }
               , new Publication { Id = 8, Date = new DateTime(), IdUser = 4, IdClasse = 5, Contenus = "this is the eightth publication." }
                );
        }


    }
}
