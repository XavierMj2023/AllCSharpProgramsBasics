using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSSQLBasics.Models
{
	public class MSSQLImage
	{
        public Guid ImageId { get; set; }
        public byte[] ImageData { get; set; }
		// Navigation property to represent the relationship
		//public ICollection<MSSQLAddData> Images { get; set; } = new List<MSSQLAddData>();
	}
}