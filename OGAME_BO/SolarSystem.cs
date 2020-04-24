using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO
{
    public class SolarSystem : IDbEntity
    {
		public long? Id { get; set; }

		[StringLength(20, MinimumLength = 5)]
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private List<Planet> planets = new List<Planet>();

		public virtual List<Planet> Planets
		{
			get { return planets; }
			set { planets = value; }
		}

		private List<Building> buildings;

		public virtual List<Building> Buildings
		{
			get { return buildings; }
			set { buildings = value; }
		}

	}
}
