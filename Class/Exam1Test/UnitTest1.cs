using Exam1;
using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Xunit;

namespace Exam1.Tests
{
    public class UnitTest1
    {
        [Fact()]
        public void GetMemberListTest()
        {
            var target = new MemberService();

            var actual = target.GetMemberList();

            var expected = new List<Member> {
                new Member { MemberId = "1049882413", MemberName = "David" },
                new Member { MemberId = "1981468336", MemberName = "Jack" }
            };


            Assert.IsType<List<Member>>(actual);
            expected.Should().BeEquivalentTo(actual);
        }

        [Fact()]
        public void GetVipMemberListTest()
        {
            var target = new MemberService();

            var actual = target.GetVipMemberList();

            var expected = new List<VipMember> {
                new VipMember { MemberId = "1049882413", MemberName = "David"},
                new VipMember { MemberId = "1981468336", MemberName = "Jack", VipMemberCardNumber = "bb6ae82a-b04b-4d50-b929-04336ccd0d7a" }
            };

            Assert.IsType<List<VipMember>>(actual);
            expected.Should().BeEquivalentTo(actual);
        }
    }
}
