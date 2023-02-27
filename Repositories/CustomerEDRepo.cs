using CodeFirstVenueBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstVenueBooking.Repositories
{
    public class CustomerEDRepo : ICustomerEDRepo
    {

        MyDbContext context;
        public CustomerEDRepo(MyDbContext customereventdetailscontext)
        {
            context = customereventdetailscontext;
        }
        public void AddNewCustomerEventDetails(CustomerEventDetails customerEventDetails)
        {
            context.CustomerEventDetails.Add(customerEventDetails);
            context.SaveChanges();
        }

        public void DeleteCustomerEventDetails(string name)
        {
            CustomerEventDetails customerEventDetails = context.CustomerEventDetails.FirstOrDefault(customerEventDetails => customerEventDetails.EventName == name);
            if (customerEventDetails != null)
            {
                context.CustomerEventDetails.Remove(customerEventDetails);
                context.SaveChanges();
            }

        }

       

        public List<CustomerEventDetails> GetAllCustomerEventDetails()
        {
            return context.CustomerEventDetails.ToList();

        }
        public CustomerEventDetails GetCustomerEventDetailsById(string name)
        {
            CustomerEventDetails customerEventDetails = context.CustomerEventDetails.Find(name);

            return customerEventDetails;
        }

        

        public void UpdateCustomerEventDetails(CustomerEventDetails newcustomerEventDetails)
        {
            CustomerEventDetails customerEventDetails = context.CustomerEventDetails.FirstOrDefault(customerEventDetails => customerEventDetails.EventName == newcustomerEventDetails.EventName);
            if (customerEventDetails != null)
            {
                customerEventDetails.EventName = newcustomerEventDetails.EventName;
                customerEventDetails.People=newcustomerEventDetails.People;
                customerEventDetails.EventDate=newcustomerEventDetails.EventDate;
                customerEventDetails.Details=newcustomerEventDetails.Details;
                customerEventDetails.UserName=newcustomerEventDetails.UserName;
                context.SaveChanges();


            } 
        }

       
    }
}
