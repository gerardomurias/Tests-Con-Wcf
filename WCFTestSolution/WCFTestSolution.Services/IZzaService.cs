using System.Collections.Generic;
using System.ServiceModel;
using WCFTestSolution.Entities;

namespace WCFTestSolution.Services
{
    [ServiceContract]
    public interface IZzaService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}