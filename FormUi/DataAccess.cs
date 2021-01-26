using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUi
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectedValue("SampleDatabase")))
            {
                var output = connection.Query<Person>($"select * from People where LastName = '{ lastname }'").ToList();
                return output;
            }
        }
    }
}
