using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO
{
    public abstract class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond()
        {
            List<Resource> result = new List<Resource>();
            return result;
        }
    }
}
