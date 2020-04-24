using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO.CustomAnnotations
{
    class PastDate : ValidationAttribute
    {
        public string Message { get; set; }
        public override bool IsValid(object obj)
        {
            DateTime updateDate = (DateTime)obj;
            if(DateTime.Now <= updateDate) {
                Message = "Le dernier update de la ressource doit être inférieure à la date actuelle";
                return false;
            }
            return true;
        }

        public override string FormatErrorMessage(string Message)
        {
            return Message;
        }
    }
}
