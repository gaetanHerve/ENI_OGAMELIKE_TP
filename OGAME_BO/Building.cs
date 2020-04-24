using OGAME_BO.CustomAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Messaging;

namespace OGAME_BO
{
    public abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
		private string name;

		[StringLength(20, MinimumLength = 5)]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int? level;

		[Range(0, int.MaxValue)]
		public int? Level
		{
			get { return level; }
			set { level = value; }
		}


		public virtual int? CellNb
		{
			get { return Level + 1; }
		}

		/*[CheckResources]*/
		public virtual List<Resource> TotalCost 
		{
			get
			{
				// A compléter
				return new List<Resource>(); 
			}
		}

		/*[CheckResources]*/
		public virtual List<Resource> NextCost
		{
			get
			{
				// A compléter
				return new List<Resource>();
			}
		}
	}
}
