using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    public class MemberService
    {
        private string _data = "[{\r\n\t\"MemberId\": \"1049882413\",\r\n\t\"MemberName\": \"David\",\r\n},\r\n{\r\n\t\"MemberId\": \"1981468336\",\r\n\t\"MemberName\": \"Jack\",\r\n\t\"VipMemberCardNumber\": \"bb6ae82a-b04b-4d50-b929-04336ccd0d7a\"\r\n}]";

        public MemberService()
        {

        }

        public List<Member> GetMemberList()
        {
            List<Member> memberList = JsonConvert.DeserializeObject<List<Member>>(this._data);

            return memberList;
        }

        public List<VipMember> GetVipMemberList()
        {
            List<VipMember> vipMemberList = JsonConvert.DeserializeObject<List<VipMember>>(this._data);

            return vipMemberList;
        }
    }
}
