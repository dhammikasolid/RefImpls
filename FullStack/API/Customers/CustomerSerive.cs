using Shared;
using System.Collections.Generic;

namespace API.Customers
{
    public class CustomerSerive
    {
        IReadRepository<Customer> readRepository;

        public CustomerSerive(IReadRepository<Customer> readRepository)
        {
            this.readRepository = readRepository;
        }

        public IEnumerable<Customer> GetAll()
        {
            return readRepository.GetAll();
        }

        public Customer Get(int id)
        {
            return readRepository.GetById(id); 
        }
    }
}