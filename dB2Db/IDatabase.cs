using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dB2Db
{
    interface IDatabase
    {
        void SaveSourceDBCredentials(string ServerName, string Username, string Password, string DatabaseName);





    }
}
