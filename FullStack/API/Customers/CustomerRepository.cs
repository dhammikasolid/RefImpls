using API.Customers;
using Dapper.Contrib.Extensions;
using Shared;
using System.Collections.Generic;
using System.Data.Common;

namespace API
{
    public class CustomerRepository : IReadRepository<Customer>
    {
        DbConnection con;

        public CustomerRepository(DbConnection con)
        {
            this.con = con;
        }

        public IEnumerable<Customer> GetAll()
        {
            return con.GetAll<Customer>();
        }

        public Customer GetById(int id)
        {
            return con.Get<Customer>(id);
        }
    }
}