using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication1.Models {
    //class especial que vai extender de uma outra que a framework entity adicionou
    //representa uma base de dados, descreve uma base de dados

    public class bdGestao : DbContext
    {
        //construtor q indica qual a base de dados a utilizar
        public bdGestao() : base("MultasDBConnectionString") { }

        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<ScoreBoard> ScoreBoard { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }

}