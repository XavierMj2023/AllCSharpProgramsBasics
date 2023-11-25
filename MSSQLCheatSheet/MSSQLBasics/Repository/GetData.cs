using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI.WebControls;
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
        public void SaveMSSQLData(MSSQLAddData adddata, HttpPostedFileBase imagefile)
		{
			SqlConnection sql = new SqlConnection(ConnectionString);
			
			try
			{
				sql.Open();
				string queryStringInsertData = "INSERT INTO MSSQLDBAdd (Id,TopicName, Syntax, Description, ImageId, ImageData) " +
											   "VALUES (@Id, @TopicName, @Syntax, @Description, @ImageId, @ImageData)";


				SqlCommand cmdInsertData = new SqlCommand(queryStringInsertData,sql);

				cmdInsertData.Parameters.AddWithValue("@Id", Guid.NewGuid());
				//cmdInsertData.Parameters.AddWithValue("@Tid", adddata.Tid);
				cmdInsertData.Parameters.AddWithValue("@TopicName", adddata.TopicName);
				cmdInsertData.Parameters.AddWithValue("@Syntax", adddata.Syntax);
				cmdInsertData.Parameters.AddWithValue("@Description", adddata.Descrption);

				// Process the image data if available
				if (imagefile != null && imagefile.ContentLength > 0)
				{
					using (var binaryReader = new BinaryReader(imagefile.InputStream))
					{
						byte[] imageData = binaryReader.ReadBytes(imagefile.ContentLength);
						adddata.ImageData = imageData; // Ensure ImageData property holds the image bytes
						cmdInsertData.Parameters.AddWithValue("@ImageId", Guid.NewGuid());
						cmdInsertData.Parameters.AddWithValue("@ImageData", imageData);
					}
				}
				else
				{
					cmdInsertData.Parameters.AddWithValue("@ImageId", DBNull.Value);
					cmdInsertData.Parameters.AddWithValue("@ImageData", DBNull.Value);
				}

				cmdInsertData.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				// Handle exceptions
				throw ex;
			}
			finally
			{
				sql.Close();
			}
		}
	}
}