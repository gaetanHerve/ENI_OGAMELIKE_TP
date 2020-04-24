using OGAME_BO.CustomAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO
{
    public abstract class ResourceGenerator : Building
    {
        /*[CheckResources]*/
        public virtual List<Resource> ResourceBySecond
        {
            get
            {
                //A compléter
                List<Resource> result = new List<Resource>();
                return result;
            }
        }
    }
}
