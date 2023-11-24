using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSQLBasics.Models;

namespace MSSQLBasics.Repository
{
    interface IGetData
	{
		void SaveMSSQLData(MSSQLAddData adddata);
	}
}
