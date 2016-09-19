using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer=(Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.PayAsYouGo
                || 
                customer.MembershipTypeId == MembershipType.Unknown)
                return ValidationResult.Success;

            if(customer.Birthdate==null)
                return new ValidationResult("Doğum Günü Gereklidir");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Üye Yaşı En Az 18 Olmalı");
        }
    }
}