using System.Collections.Generic;
using System.Reflection;

namespace OGAME_BO
{
    public class Planet : IDbEntity
    {
        public long? Id { get; set; }
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int? caseNb;

		public int? CaseNb
		{
			get { return caseNb; }
			set { caseNb = value; }
		}
		private List<Resource> resources = new List<Resource>();

		public List<Resource> Resources
		{
			get { return resources; }
			set { resources = value; }
		}
		private List<Building> buildings = new List<Building>();

		public List<Building> Buildings
		{
			get { return buildings; }
			set { buildings = value; }
		}

	}
}