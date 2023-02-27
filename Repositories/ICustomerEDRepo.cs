using CodeFirstVenueBooking.Models;
using System.Collections.Generic;

namespace CodeFirstVenueBooking.Repositories
{
    public interface ICustomerEDRepo
    {
        List<CustomerEventDetails> GetAllCustomerEventDetails();
        void AddNewCustomerEventDetails(CustomerEventDetails custumerEventDetails);
        
        CustomerEventDetails GetCustomerEventDetailsById(string name);
        void DeleteCustomerEventDetails(string name);
       
        void UpdateCustomerEventDetails(CustomerEventDetails customerEventDetails);
    }
}
