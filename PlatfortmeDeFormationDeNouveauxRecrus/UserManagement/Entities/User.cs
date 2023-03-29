﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public List<Role> Roles { get; set; }
        //public byte[]? Image { get; set; }

        // public Departement Departement { get; set; }
        //   public List<Reclamation> Reclamations { get; set; }

    }
}
