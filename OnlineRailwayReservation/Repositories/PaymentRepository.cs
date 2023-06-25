using System.Collections.Generic;
using System.Linq;
using OnlineRailwayReservation.Models;
using RailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{


    public class PaymentRepository
    {
        private readonly RailwayReservationContext _context;

        public PaymentRepository(RailwayReservationContext context)
        {
            _context = context;
        }

        public List<Payment> GetAllPayments()
        {
            return _context.Payment.ToList();
        }

        public Payment GetPaymentById(int id)
        {
            return _context.Payment.FirstOrDefault(p => p.Id == id);
        }

        public void AddPayment(Payment payment)
        {
            _context.Payment.Add(payment);
            _context.SaveChanges();
        }

        public void UpdatePayment(Payment payment)
        {
            _context.Payment.Update(payment);
            _context.SaveChanges();
        }

        public void DeletePayment(int id)
        {
            var payment = _context.Payment.FirstOrDefault(p => p.Id == id);
            if (payment != null)
            {
                _context.Payment.Remove(payment);
                _context.SaveChanges();
            }
        }
    }
}
