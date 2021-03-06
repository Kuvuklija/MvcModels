﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcModels.Models{

    [DisplayName("New Person")]
    public partial class Person{
       // [HiddenInput(DisplayValue =true)] // hidden for user but tags are existing
        //[ScaffoldColumn(false)]            full delate tags exeption EditorFor and etc.
        public int PersonId { get; set; }
        [Display(Name ="First")]
        [UIHint("MultilineText")]
        public string FirstName { get; set; }
        [Display(Name ="Last")]
        public string LastName { get; set; }
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Address HomeAddress { get; set; }
        [Display(Name ="Approved")]
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }

    public class Address {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum Role {
        Admin,
        User,
        Guest
    }
}