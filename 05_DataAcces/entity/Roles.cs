using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace principal._05_DataAcces.entity
{
    [Table("Rol")]
    public class Rol
    {

        #region datos
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idRol { get; set; }

        public string nombre { get; set; }

        #endregion

        #region relaciones
            public  ICollection<Usuario> Usuarios { get; set; }
        #endregion
    }
}
