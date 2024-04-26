using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace principal._05_DataAcces.entity
{

  
    [Table("Usuario")]
    public class Usuario
    {
        #region datos
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
       public string idUsuario { get; set; }
       public string nombre { get; set; }

       public string correo { get; set; }

       public string contraseña { get; set; }

       public Boolean activo { get; set; }

        #endregion

        #region relaciones
        public ICollection<Rol> Roles { get; set; }
        #endregion
    }
}


