using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MSSQLBasics.Models;

namespace MSSQLBasics.Repository
{
	public class GetData : IGetData
	{
		public string ConnectionString {  get; set; }
        public GetData()
        {
			ConnectionString = ConfigurationManager.ConnectionStrings["mssqlche"].ConnectionString;
        }
        public void SaveMSSQLData(MSSQLAddData adddata)
		{
			
		}
	}
}