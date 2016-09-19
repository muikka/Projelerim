using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Lütfen İsmi Giriniz")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Haber Kanalına Üyelik")]
        public bool IsSubscribedToNewsletter { get; set; }

//        [Required]
//        [Display(Name = "Üyelik Tipi")]
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Üyelik Tipi Id")]
        [Required]
        public byte? MembershipTypeId { get; set; }

        [Display(Name = "Doğum Günü")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}