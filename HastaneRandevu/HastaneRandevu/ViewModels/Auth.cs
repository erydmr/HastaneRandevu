using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HastaneRandevu.ViewModels
{
    public class Auth
    {
        public class AuthLogin
        {
            [Required]
            public string TcKimlik { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Sifre { get; set; }

        }
    }
}