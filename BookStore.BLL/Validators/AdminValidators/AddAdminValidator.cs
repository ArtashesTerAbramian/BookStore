using BookStore.DTO.AdminDtos;
using FluentValidation;

namespace BookStore.BLL.Validators.AdminValidators;

public class AddAdminValidator : AbstractValidator<AddAdminDto>
{
    public AddAdminValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(70);

        RuleFor(x => x.Name).MaximumLength(35);

        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(6)
            .MaximumLength(16);

        RuleFor(x => x.UserName)
            .NotEmpty()
            .MinimumLength(25);
    }
}