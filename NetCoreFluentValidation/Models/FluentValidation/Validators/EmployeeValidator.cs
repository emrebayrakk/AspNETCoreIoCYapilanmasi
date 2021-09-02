using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace NetCoreFluentValidation.Models.FluentValidation.Validators
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Adı Boş Geçemezsiniz");

            RuleFor(x => x.EmployeeLastName).NotEmpty().WithMessage("Soyadını Boş Geçemezsiniz");

            RuleFor(x => x.EmployeeEmail).NotEmpty().WithMessage("Mail Boş Geçemezsiniz");
        }
    }
}
