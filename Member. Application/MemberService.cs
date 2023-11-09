using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }
        List<Domain.Member> IMemberService.GetAllMembers()
        {
            return this.memberRepository.GetAllMembers();
        }
    }
}
