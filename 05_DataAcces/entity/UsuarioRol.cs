namespace principal._05_DataAcces.entity
{
    
    public class UsuarioRol
    {
        public string UsuarioId { get; set; }
        public string RolesId { get; set; }

        public Usuario Usuario { get; set; }
        public Rol Rol { get; set; }
    }
}
