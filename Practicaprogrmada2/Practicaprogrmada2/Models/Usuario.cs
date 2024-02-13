using System.ComponentModel.DataAnnotations;

namespace Practicaprogrmada2.Models
{
    public class Usuario
    {
        [Key]
            public string usuario
            {
                get; set;
            }

            public string contrasena
            {
                get; set;
            }

            public string correo
            {
                get; set;
            }

            public int numTelefonico
            {
                get; set;
            }

    }
}
