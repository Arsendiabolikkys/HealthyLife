using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLife.Models
{
    public class AccountViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName(Constants.Account.Name)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength=3)]
        [DisplayName(Constants.Account.SecondName)]
        public string SecondName { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName(Constants.Account.DateOfBirth)]
        [UIHint("DateTime")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName(Constants.Account.Email)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName(Constants.Account.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [DisplayName(Constants.Account.ConfirmPassword)]
        public string ConfirmPassword { get; set; }

        [DisplayName(Constants.Account.Photo)]
        public string Photo { get; set; }

        public AddressViewModel Address { get; set; }

        public PatientViewModel Patient { get; set; }

        public DoctorViewModel Doctor { get; set; }

        public bool IsDoctor { get; set; }

        public AccountViewModel(){}
    }
}