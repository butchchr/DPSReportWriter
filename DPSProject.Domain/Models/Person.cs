using System;

namespace DPSProject.Domain.Models
{
    class Person
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Alias { get; set; }

        public string Suffix { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string DriversLicense { get; set; }

        public string OtherId { get; set; }

        public string PhoneOne { get; set; }

        public string PhoneTwo { get; set; }

        public string PhoneThree { get; set; }

        public string EmailOne { get; set; }

        public string EmailTwo { get; set; }

        public string AddressOne { get; set; }

        public string AddressTwo { get; set; }
    }
}
