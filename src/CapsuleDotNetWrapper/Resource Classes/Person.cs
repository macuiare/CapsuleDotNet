﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CapsuleDotNetWrapper
{
    /// <summary>
    /// http://developer.capsulecrm.com/v1/resources/parties/
    /// </summary>
    public class Person
    {
        public string id { get; set; }
        //public DateTime createdOn { get; set; }
        //public DateTime updatedOn { get; set; }
        public Contacts contacts { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        //public string organisationId { get; set; }
        public string organisationName { get; set; }
    }

    public class PersonToCreate
    {
        public Person person { get; set; }
    }


    public class Contacts
    {
        public Email email { get; set; }
        public Phone phone { get; set; }


    }

    public class Email
    {
        public string type { get; set; }
        public string emailAddress { get; set; }


    }


    public class Phone
    {
        public string type { get; set; }
        public string phoneNumber { get; set; }

    }

}
