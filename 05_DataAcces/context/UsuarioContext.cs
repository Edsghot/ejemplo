using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using principal._05_DataAcces.entity;



namespace principal._05_DataAcces.context
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Rol>? Roles { get; set; }
        public DbSet<UsuarioRol>? UsuarioRol { get; set; }

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)        {        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*List<Roles> usuarioInit = new List<Roles>
            {
                new Roles() { idRol = Guid.Parse("71f85363-78c6-40b3-8de2-dc7fa1c2a0af"), nombre = "admin" }
            };*/

            //tabla union
            modelBuilder.Entity<UsuarioRol>()
                 .HasKey(ur => new { ur.UsuarioId, ur.RolesId });
            /*
            //tabla usuario
            modelBuilder.Entity<UsuarioRol>()
                        .HasOne(ur => ur.Usuario)
                        .WithMany(u => u.Roles)
                        .HasForeignKey(ur => ur.UsuarioId);

            modelBuilder.Entity<UsuarioRol>()
                 .HasOne(ur => ur.Roles)
                 .WithMany(u => u.Usuario)
                 .HasForeignKey(ur => ur.RolesId);*/

        }
    }
}
