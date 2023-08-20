using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProjectPWA
{
    [Serializable]
    public class PaymentRepository
    {
        private readonly List<Payment> _payments;

        public PaymentRepository()
        {
            _payments = new List<Payment>();
        }

        public void Add(Payment payment)
        {
            payment.Id = _payments.Any() ? _payments.Max(p => p.Id) + 1 : 1;
            _payments.Add(payment);
        }

        public Payment GetById(int id)
        {
            return _payments.FirstOrDefault(p => p.Id == id);
        }
       
        public void Update(Payment payment)
        {
            var existingPayment = GetById(payment.Id);
            existingPayment.Member = payment.Member;
            existingPayment.Amount = payment.Amount;
            existingPayment.PaymentDate = payment.PaymentDate;
        }

        public void Delete(int id)
        {
            var payment = GetById(id);
            _payments.Remove(payment);
        }
    }
}
