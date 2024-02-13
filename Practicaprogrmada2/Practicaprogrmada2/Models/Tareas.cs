using System.ComponentModel.DataAnnotations;

namespace Practicaprogrmada2.Models
{
    public class Tareas
    {
        [Key]
        public int idTarea { get; set; }
        public string nomTarea { get; set; }
        public int idLista { get; set; }
    }
}
