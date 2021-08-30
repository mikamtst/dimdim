using DimDim.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimDim.Context
{
    public class CrudContexto : DbContext
    {
        public CrudContexto(DbContextOptions<CrudContexto> options) : base (options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ContaBancaria> ContaBancaria { get; set; }
        public DbSet<Ted> Ted { get; set; }
    }
}
