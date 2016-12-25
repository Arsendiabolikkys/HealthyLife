using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class Account : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string SecondName { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual string PasswordSalt { get; set; }

        public virtual string Photo { get; set; }

        public virtual int AddressId { get; set; }

        public virtual int RoleId { get; set; }
    }
}