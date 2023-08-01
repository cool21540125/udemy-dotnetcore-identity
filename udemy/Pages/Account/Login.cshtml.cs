using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_UnderTheHood.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {            
        }

        public void OnPost()
        {

        }
    }

    public class Credential
    {
        [Required]        
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]        
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}