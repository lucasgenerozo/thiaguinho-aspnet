using Microsoft.EntityFrameworkCore;
using Thiaguinho.Models;

namespace Thiaguinho.Data
{
    public class ConnectionContext : DbContext
    {

        /*  
         *   CREATE LOGIN novoUsuario WITH PASSWORD = 'SenhaSegura123!';
         *   USE LPADS2024T2;
         *   GO
         *
         *   CREATE USER novoUsuario FOR LOGIN novoUsuario;

         *   ALTER ROLE db_owner ADD MEMBER novoUsuario;
         */
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Cursos { get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options) :
        base(options)
        { }


    }
}