using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ClienteApi.Database
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext>
       options) : base (options){

       } 

       public DbSet<Usuario> Usuarios{get; set;}


       protected override void OnModelCreating(ModelBuilder modelBuilder){
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable  ("usuarios");
            usuario.HasKey(x=> x.Id);
            usuario.Property(x=> x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x=> x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x=> x.Cpf).HasColumnName("cpf").IsRequired();
            usuario.Property(x=> x.Rua).HasColumnName("rua").IsRequired();
            usuario.Property(x=> x.Uf).HasColumnName("uf").IsRequired();
            usuario.Property(x=> x.Email).HasColumnName("email").IsRequired();
            usuario.Property(x=> x.Senha).HasColumnName("senha").IsRequired();
        }
    }
}