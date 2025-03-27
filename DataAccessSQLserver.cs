using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examen
{
    class DataAccessSQLserver
    {
            public string connectionString;

            public DataAccessSQLserver()
            {
            connectionString = "Server=HOMERIG;Database=examendatabase;Trusted_Connection=True;Timeout=120;";
            }
    }
}


