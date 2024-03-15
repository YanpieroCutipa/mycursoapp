using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mycursoapp.Models
{
    public class Datos
    {
        [Display(Name = "Nombre del Curso")]
        [Required(ErrorMessage = "El campo del nombre curso es obligatorio.")]
        public string Nombre { get; set; }

        [Display(Name = "Seleccione Categoria")]
        [Required(ErrorMessage = "El campo de la categoria es obligatorio.")]
        public string Categoria { get; set; }

        [Display(Name = "Número de Créditos")]
        [Required(ErrorMessage = "El campo del credito es obligatorio.")]
        public int Creditos { get; set; }

        [Display(Name = "Esoja Modalidad")]
        [Required(ErrorMessage = "Por favor seleccione una modalidad.")]
        public string Modalidad { get; set; }

        [Display(Name = "Material")]
        public bool IncluyeMaterial { get; set; }
        [Display(Name = "Videos")]
        public bool IncluyeVideos { get; set; }

        [Display(Name = "Número de Horas")]
        [Required(ErrorMessage = "El campo del numero de horas es obligatorio.")]
        public int Horas { get; set; }

        public double Pago()
        {
            return Horas * 100;
        }
    }
}

