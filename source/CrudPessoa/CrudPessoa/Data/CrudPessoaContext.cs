using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudPessoa.Models;

namespace CrudPessoa.Context
{
    public class CrudPessoaContext : DbContext
    {
        public CrudPessoaContext (DbContextOptions<CrudPessoaContext> options)
            : base(options)
        {
        }

        public DbSet<CrudPessoa.Models.Pessoa> Pessoa { get; set; }
        public DbSet<CrudPessoa.Models.Email> Email { get; set; }
    }
}
