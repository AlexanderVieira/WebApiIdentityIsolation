using System;

namespace Test.XUnit
{
    public class User
    {
        public string Id { get; set; }

        public virtual string Email { get; set; }

        public virtual bool EmailConfirmed { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string SecurityStamp { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual bool PhoneNumberConfirmed { get; set; }

        public virtual bool TwoFactorEnabled { get; set; }

        public virtual DateTime? LockoutEndDateUtc { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public virtual int AccessFailedCount { get; set; }

        public virtual string UserName { get; set; }
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }

        public User(string email, string phoneNumber, string userName)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            UserName = userName;
        }

        public User(
            string email, 
            bool emailConfirmed, 
            string passwordHash, 
            string securityStamp, 
            string phoneNumber, 
            bool phoneNumberConfirmed, 
            bool twoFactorEnabled, 
            DateTime? lockoutEndDateUtc, 
            bool lockoutEnabled, 
            int accessFailedCount, 
            string userName)
        {            
            Email = email;
            EmailConfirmed = emailConfirmed;
            PasswordHash = passwordHash;
            SecurityStamp = securityStamp;
            PhoneNumber = phoneNumber;
            PhoneNumberConfirmed = phoneNumberConfirmed;
            TwoFactorEnabled = twoFactorEnabled;
            LockoutEndDateUtc = lockoutEndDateUtc;
            LockoutEnabled = lockoutEnabled;
            AccessFailedCount = accessFailedCount;
            UserName = userName;
        }
    }
}
