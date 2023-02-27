using CodeFirstVenueBooking.Models;
using System.Collections.Generic;

namespace CodeFirstVenueBooking.Repositories
{
    public interface IPaymentRepo
    {
        List<Payment> GetAllPayments();
        void AddNewPayment(Payment payment);
        void UpdatePayment(Payment payment);
        Payment GetPaymentById(int id);
        void DeletePayment(int id);
    }
}
