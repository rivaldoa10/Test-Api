using System.ComponentModel.DataAnnotations;

namespace Pelicula_Api_Test.DTO
{
    public class GeneroCreacionDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(ErrorMessage = "El campo {0} permite una cantidad de {1} caracteres")]
        public string Nombre { get; set; }
    }
}
