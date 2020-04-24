using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO
{
    public abstract class FunctionBuilding : Building
    {
        public List<Action> Actions()
        {
            List<Action> result = new List<Action>();
            return result;
        }
    }
}
