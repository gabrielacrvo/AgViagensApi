using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinosApi.Model;
using Microsoft.EntityFrameworkCore;

namespace DestinosApi.Database
{

     public class DestinoDbContext : DbContext 
{
    public DestinoDbContext(DbContextOptions<DestinoDbContext>
       options) : base (options){
           
        } 
       public DbSet<Destino> Destinos {get; set;}
      
      protected override void OnModelCreating(ModelBuilder modelBuilder){
            var destino = modelBuilder.Entity<Destino>();
            destino.ToTable  ("destinos");
            destino.HasKey(x=> x.Id);
            destino.Property(x=> x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            destino.Property(x=> x.Cidade).HasColumnName("destino").IsRequired();
            destino.Property(x=> x.Uf).HasColumnName("uf").IsRequired();
            destino.Property(x=> x.Valor).HasColumnName("valor").IsRequired();

}

}
}