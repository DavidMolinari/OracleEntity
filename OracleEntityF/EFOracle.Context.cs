﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OracleEntityF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OracleEntities : DbContext
    {
        public OracleEntities()
            : base("name=OracleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<COUR> COURS { get; set; }
        public DbSet<EMPLOYE> EMPLOYEs { get; set; }
        public DbSet<INSCRIT> INSCRITs { get; set; }
        public DbSet<PARTICIPER> PARTICIPERs { get; set; }
        public DbSet<PROJET> PROJETs { get; set; }
        public DbSet<SEMINAIRE> SEMINAIREs { get; set; }
    }
}