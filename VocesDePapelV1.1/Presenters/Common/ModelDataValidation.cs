using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VocesDePapelV1._1.Presenters.Common
{
    public class ModelDataValidation
    {
        //metodo para validar un modelo usando data annotations
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true); //true para validar todas las propiedades
            if (isValid == false)
            {
                foreach (var item in results)
                {
                    errorMessage += "-"+ item.ErrorMessage + "\n"; //concatenamos los mensajes de error
                    
                }
                throw new Exception(errorMessage); //lanzamos una excepcion con los mensajes de error
            }
        }
    }
}
