//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stktakip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Login
    {
        public short Id { get; set; }
         [Display(Name ="Kullan�c� Ad�")]
        [Required(ErrorMessage ="L�tfen Kullan�c� Ad�n�z� Giriniz...!")]
        public string UserName { get; set; }
         [Display(Name ="�ifre")]
        [Required(ErrorMessage ="L�tfen �ifrenizi Giriniz...!")] 
       public string Password { get; set; }
        public string Role { get; set; }
    }
}
