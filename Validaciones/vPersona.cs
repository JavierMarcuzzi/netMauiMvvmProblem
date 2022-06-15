using System;
using AppMarkupValidator.Modelos;
using FluentValidation;

namespace AppMarkupValidator.Validaciones
{
    // muy bueno https://www.youtube.com/watch?v=YbxeNvn5Xm8&t=1s
    public class vPersona : AbstractValidator<mPersona>
    {
        public vPersona()
        {
            RuleFor(x => x.Name).NotNull().Length(5, 20).NotEqual("Javier");
            //	RuleFor(x => x.Password).NotNull();
            //	RuleFor(x => x.ConfirmPassword).NotNull().Equal(x => x.Password);
            //	RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.Surname).NotNull().Length(4, 20);
        }
    }
}