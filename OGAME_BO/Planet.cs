using OGAME_BO.CustomAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace OGAME_BO
{
    public class Planet : IDbEntity
    {
        public long? Id { get; set; }

		private string name;

		[StringLength(20, MinimumLength = 5)]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int? caseNb;

		[Range(0, int.MaxValue)]
		public int? CaseNb
		{
			get { return caseNb; }
			set { caseNb = value; }
		}
		private List<Resource> resources = new List<Resource>();

		[CheckResources]
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