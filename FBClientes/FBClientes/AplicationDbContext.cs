using FBClientes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBClientes
{
    public class AplicationDbContext : DbContext
    {
       public DbSet<PersonaCliente> PersonaCliente { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
