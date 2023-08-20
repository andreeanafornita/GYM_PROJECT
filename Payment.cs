using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProjectPWA
{
    [Serializable]
    public class Payment
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
