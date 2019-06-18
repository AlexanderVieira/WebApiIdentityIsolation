using Xunit;
using ExpectedObjects;
using System;

namespace Test.XUnit
{
    public class UserTest
    {
        [Fact(DisplayName ="Create User")]
        public void TestCreateUser()
        {
            //########################### Cenario ###########################
            var expectedUser = new
            {
                Email = "alex@teste.com",
                EmailConfirmed = true,
                PasswordHash = "123456",
                SecurityStamp = "15",
                PhoneNumber = "975727477",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEndDateUtc = DateTime.Now,
                LockoutEnabled = false,
                AccessFailedCount = 1,
                UserName = "Alex"               
            };

            //############################ Acao ##############################                         

            var user = new User(expectedUser.Email,
                expectedUser.EmailConfirmed,
                expectedUser.PasswordHash,
                expectedUser.SecurityStamp,
                expectedUser.PhoneNumber,
                expectedUser.PhoneNumberConfirmed,
                expectedUser.TwoFactorEnabled,
                expectedUser.LockoutEndDateUtc,
                expectedUser.LockoutEnabled,
                expectedUser.AccessFailedCount,
                expectedUser.UserName);            

            //######################### Verificacao ##########################
            //Assert.Equal(expectedUser.Email,user.UserName);
            expectedUser.ToExpectedObject().ShouldMatch(user);
        }
    }
}
