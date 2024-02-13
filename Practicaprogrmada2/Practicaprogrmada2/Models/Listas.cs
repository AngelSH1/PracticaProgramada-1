using System.ComponentModel.DataAnnotations;

namespace Practicaprogrmada2.Models
{
    public class Listas
    {
        [Key]
        public int idLista
        {
            get; set;
        }
        public string nomLista
        {
            get; set;
        }
        public string usuario
        {
            get; set;
        }

    }
}
