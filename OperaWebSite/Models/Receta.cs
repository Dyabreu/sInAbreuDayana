using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaWebMisRecetas.Validations;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        [StringLength(50)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Desayuno]
        public string Categoria { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (100)")]
        [StringLength(50)]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (100)")]
        [StringLength(50)]
        [DataType(DataType.MultilineText)]

        public string Instrucciones { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        [StringLength(50)]
        public string Autor { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        [StringLength(50)]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Mayor18]
        public int Edad { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        [StringLength(50)]
        [RegularExpression(".+\\@.+\\..+")]

        public string Email { get; set; }
    }
}
