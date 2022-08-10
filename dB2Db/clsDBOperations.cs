using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dB2Db
{
    public class clsDBOperations : IDatabase
    {
        /// <summary>
        /// Stores the source database details in the typed dataset
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <param name="DatabaseName"></param>
        public void SaveSourceDBCredentials(string ServerName, string Username, string Password, string DatabaseName)
        {
            dsServerDataBaseDetails dbDetails = new dsServerDataBaseDetails();
            dbDetails.Tables[0].Rows.Add(ServerName, Username, Password, DatabaseName);            
        }
    }
}
