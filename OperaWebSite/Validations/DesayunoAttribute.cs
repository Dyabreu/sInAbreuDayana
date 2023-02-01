using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class DesayunoAttribute : ValidationAttribute
    {
        public DesayunoAttribute()
        {
            ErrorMessage = "Categoría sólo puede ser 'DESAYUNO'.";
        }

        public override bool IsValid(object value)
        {
            string categoria = Convert.ToString(value);

            if (categoria == "Desayuno" || categoria == "DESAYUNO" || categoria == "desayuno")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
