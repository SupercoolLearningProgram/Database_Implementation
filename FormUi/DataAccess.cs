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
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastname }'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastname }).ToList();
                return output;
            }
        }

        internal void insertPerson(string firstname, string lastname, string emailaddress, string phonenumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectedValue("SampleDatabase")))
            {
                Person newPerson = new Person { FirstName = firstname,LastName = lastname,EmailAddress = emailaddress, PhoneNumber = phonenumber}
            }
        }
    }
}
