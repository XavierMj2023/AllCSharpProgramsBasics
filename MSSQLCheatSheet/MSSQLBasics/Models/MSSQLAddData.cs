using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSSQLBasics.Models
{
	public class MSSQLAddData
	{
		public Guid Id { get; set; }
		public int Tid { get; set; }
		public string TopicName { get; set; }
		public string Syntax { get; set; }
		public string Descrption { get; set; }
		// Foreign key property
		public Guid ImageId { get; set; }

		// Navigation property to represent the relationship
		public MSSQLImage MSSQLImage { get; set; }
		public string HighDescrption { get; set; }
	}
}