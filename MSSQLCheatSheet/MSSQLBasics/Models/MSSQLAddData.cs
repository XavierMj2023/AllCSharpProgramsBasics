using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
		public byte[] ImageData { get; set; }
		//public string FileLocation { get; set; }

		// Navigation property to represent the relationship
		//public MSSQLImage MSSQLImage { get; set; }
	}
}