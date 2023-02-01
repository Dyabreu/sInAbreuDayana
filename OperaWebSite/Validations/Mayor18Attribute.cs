using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class Mayor18Attribute : ValidationAttribute
    {
        public Mayor18Attribute()
        {
            ErrorMessage = "Edad debe ser igual o mayor a 18.";
        }

        public override bool IsValid(object value)
        {
            int edad = (int)value;

            if (edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
