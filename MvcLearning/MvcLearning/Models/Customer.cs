﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public int  Id { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        public bool MembershipTypeId { get; set; }
    }
}