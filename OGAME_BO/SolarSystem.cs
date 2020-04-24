using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO
{
    public class SolarSystem : IDbEntity
    {
		public long? Id { get; set; }
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private List<Planet> planets = new List<Planet>();

		public List<Planet> Planets
		{
			get { return planets; }
			set { planets = value; }
		}


	}
}
