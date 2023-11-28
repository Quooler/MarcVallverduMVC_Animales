using System.ComponentModel.DataAnnotations;

namespace MVC_MarcVallverdu.Models
{
    public class Animal
    {
        private int idAnimal;
        private string nombre;

        [Required]
        [Range(1, 50, ErrorMessage = "El valor para {0} debe ser entre {1} y {2}.")]
        public int IdAnimal 
        { 
            get { return idAnimal; } 
            set { idAnimal = value; } 
        }

        [Required]
        [Display(Name = "Animal")]
        [StringLength(10, ErrorMessage = "El nombre del animal introducido no puede exceder los 10 carácteres.")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
