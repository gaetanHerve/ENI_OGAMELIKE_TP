using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace OGAME_BO
{
    public abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int? level;

		public int? Level
		{
			get { return level; }
			set { level = value; }
		}

		public abstract int? CellNb();

		public List<Resource> TotalCost()
		{
			List<Resource> result = new List<Resource>();
			return result;
		}

		public List<Resource> NextCost()
		{
			List<Resource> result = new List<Resource>();
			return result;
		}
	}
}
