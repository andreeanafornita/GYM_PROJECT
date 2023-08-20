using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProjectPWA
{
    [Serializable]
    public class MemberRepository
    {
        private readonly List<Member> _members;

        public MemberRepository()
        {
            _members = new List<Member>();
        }

        public void Add(Member member)
        {
            member.Id = _members.Any() ? _members.Max(m => m.Id) + 1 : 1;
            _members.Add(member);
        }

        public Member GetById(int id)
        {
            return _members.FirstOrDefault(m => m.Id == id);
        }

        public void Update(Member member)
        {
            var existingMember = GetById(member.Id);
            existingMember.Name = member.Name;
            existingMember.DateOfBirth = member.DateOfBirth;
            existingMember.Email = member.Email;
            existingMember.Phone = member.Phone;
            existingMember.MembershipType = member.MembershipType;
        }

        public void Delete(int id)
        {
            var member = GetById(id);
            _members.Remove(member);
        }
    }
}
