using System;

namespace OGAME_BO
{
    public class Resource : IDbEntity
    {
        public long? Id { get; set; }

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int? lastQuantity;

		public int? LastQuantity
		{
			get { return lastQuantity; }
			set { lastQuantity = value; }
		}
		private DateTime lastUpdate;

		public DateTime LastUpdate
		{
			get { return lastUpdate; }
			set { lastUpdate = value; }
		}
	}
}