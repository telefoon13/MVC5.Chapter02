using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Gelieven een naam in te vullen.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Gelieven een email in te vullen.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Gelieven een geldig email te geven.")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Gelieven een telefoon nummer in te vullen.")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Gelieven een optie te kiezen.")]
        public bool? WillAttend { get; set; }
        //? na bool wil zeggen Nullable bool (kan true/false of null zijn )
    }
}