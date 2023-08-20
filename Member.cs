using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProjectPWA
{
    [Serializable]
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public MembershipType MembershipType { get; set; }
        public DateTime RegistrationDate { get; set; }

        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
