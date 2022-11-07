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
       public DbSet<Destino> Destino{get; set;}
      
}

}