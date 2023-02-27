using CodeFirstVenueBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstVenueBooking.Repositories
{
    public class PaymentRepo : IPaymentRepo
    {
        MyDbContext context;
        public PaymentRepo(MyDbContext paymentcontext)
        {
            context = paymentcontext;
        }
        public void AddNewPayment(Payment payment)
        {
            context.Payments.Add(payment);
            context.SaveChanges();
        }

        

        public void DeletePayment(int id)
        {
            Payment payment = context.Payments.FirstOrDefault(payment=> payment.Bno == id);
            if (payment != null )
            {
                context.Payments.Remove(payment);
                context.SaveChanges();
            }

        }
        public List<Payment> GetAllPayments()
        {
            return context.Payments.ToList();

        }
        public Payment GetPaymentById(int id)
        {
            Payment payment = context.Payments.Find(id);

            return payment;
        }
        public void UpdatePayment(Payment newpayment)
        {
            Payment payment = context.Payments.FirstOrDefault(p => p.Bno == newpayment.Bno);
            if (payment != null)
            {
                payment.BDate = newpayment.BDate;
                payment.Amount = newpayment.Amount;
                payment.EventType= newpayment.EventType;
                payment.UserName = newpayment.UserName;
                payment.PaymentType= newpayment.PaymentType;
                payment.Details= newpayment.Details;
                context.SaveChanges();
            }
        }
    }
   
}
