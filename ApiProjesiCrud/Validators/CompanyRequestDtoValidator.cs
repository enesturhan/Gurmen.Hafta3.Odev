using ApiProjesiCrud.Dtos;
using FluentValidation;

namespace ApiProjesiCrud.Validators
{
    public class CompanyRequestDtoValidator: AbstractValidator<CompanyDto>
    {
        public CompanyRequestDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("isim yılı boş geçilemez.");
            RuleFor(x => x.Address).NotNull().WithMessage("Adress alanı boş olamaz");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Telefon No alanı boş olamaz");
            RuleFor(x => x.TaxNumber).NotNull().WithMessage("Tax alanı boş olamaz");
            RuleFor(x => x.Country).NotNull().WithMessage("Country name alanı boş olamaz");
          
        }
      
    }
}
