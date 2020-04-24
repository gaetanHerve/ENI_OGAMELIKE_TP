using OGAME_BO.CustomAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace OGAME_BO
{
    public class Resource : IDbEntity
    {
        public long? Id { get; set; }

		[StringLength(20, MinimumLength = 5)]
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int? lastQuantity;

		[Range(0, int.MaxValue)]
		public int? LastQuantity
		{
			get { return lastQuantity; }
			set { lastQuantity = value; }
		}
		private DateTime lastUpdate;

		[PastDate]
		public DateTime LastUpdate
		{
			get { return lastUpdate; }
			set { lastUpdate = value; }
		}
	}
}