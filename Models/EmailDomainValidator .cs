using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;
using static  FirstBlazorApp.Models.EmployeeContext ;

namespace FirstBlazorApp.Models
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            //EmployeeContext emp ;
            //var getStaff= EmployeeContext().GetAll<volunteer>("volunteer");
            string[] strings = value.ToString().Split('@');
            if (strings[1].ToUpper() == AllowedDomain.ToUpper())
            {
                return null;
            }

            return new ValidationResult($"Domain must be {AllowedDomain}",
            new[] { validationContext.MemberName });
        }
    }
}
