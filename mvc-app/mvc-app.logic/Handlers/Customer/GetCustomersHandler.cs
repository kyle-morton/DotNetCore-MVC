using mvc_app.data.Repositories;
using System.Collections.Generic;

namespace mvc_app.logic.Handlers.Customer
{

    public interface IGetCustomersHandler
    {
        GetCustomersResponse Handle(GetCustomersRequest request);
    }

    public class GetCustomersHandler : IGetCustomersHandler
    {

        private ICustomerRepository _repo;
        public GetCustomersHandler(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public GetCustomersResponse Handle(GetCustomersRequest request)
        {
            return new GetCustomersResponse
            {
                Customers = _repo.GetCustomers()
            };
        }

    }

    public class GetCustomersRequest { }
    public class GetCustomersResponse
    {
        public IList<shared.Models.Customer> Customers { get; set; }
    }
}
