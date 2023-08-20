using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProjectPWA
{
    [Serializable]
    public class MembershipTypeRepository
    {
        public readonly List<MembershipType> _membershipTypes;

        public MembershipTypeRepository()
        {
            _membershipTypes = new List<MembershipType>();
        }

        public void Add(MembershipType membershipType)
        {
            membershipType.Id = _membershipTypes.Any() ? _membershipTypes.Max(mt => mt.Id) + 1 : 1;
            _membershipTypes.Add(membershipType);
        }

        public MembershipType GetById(int id)
        {
            return _membershipTypes.FirstOrDefault(mt => mt.Id == id);
        }

        public MembershipType GetByName(string name)
        {
            return _membershipTypes.FirstOrDefault(m => m.Name == name);
        }
        public List<MembershipType> GetAll()
        {
            return _membershipTypes;
        }
        public void Update(MembershipType membershipType)
        {
            var existingMembershipType = GetById(membershipType.Id);
            existingMembershipType.Name = membershipType.Name;
            existingMembershipType.Price = membershipType.Price;
            existingMembershipType.DurationInDays = membershipType.DurationInDays;
        }

        public void Delete(int id)
        {
            var membershipType = GetById(id);
            _membershipTypes.Remove(membershipType);
        }
    }
}
