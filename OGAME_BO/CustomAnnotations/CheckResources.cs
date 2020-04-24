using OGAME_BO.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO.CustomAnnotations
{
    class CheckResources : ValidationAttribute
    {
        public string Message { get; set; }
        public override bool IsValid(object obj)
        {
            List<Resource> resources = (List<Resource>)obj;
            if ((resources.Count != resources.Distinct().Count()) || resources.Count > 4)
            {
                Message = "Il existe déjà une ressource de ce type pour la planète";
                return false;
            } else if (resources.Count > 4) {
                Message = "Une planète ne peut pas avoir plus de 4 ressources";
                return false;
            }
            foreach (Resource resource in resources)
            {
                if (!ResourcesTypes.GetValues(typeof(string)).Cast<string>().ToList().Contains(resource.Name))
                {
                    Message = $"La ressource {resource} n'existe pas";
                    return false;
                }
                    
            }
                return true;
        }

        public override string FormatErrorMessage(string Message)
        {
            return Message;
        }
    }
}
