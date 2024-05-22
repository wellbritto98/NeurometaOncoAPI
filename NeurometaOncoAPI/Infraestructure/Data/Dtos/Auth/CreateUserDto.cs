using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeurometaOncoAPI.Infraestructure.Data.Dtos.Auth
{
    public class RegisterUserDto : IValidatableObject
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "A senha de confirmação deve ser igual à senha.")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "Você deve concordar com os termos.")]
        public bool AgreeTerms { get; set; }

        [Required]
        public string EnderecoCompleto { get; set; }

        [Required]
        public string Role { get; set; } = "Paciente";

        public string? FotoPerfil { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public string Rg { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Password != PasswordConfirmation)
            {
                yield return new ValidationResult("A senha de confirmação deve ser igual à senha.", new[] { nameof(PasswordConfirmation) });
            }

            if (!AgreeTerms)
            {
                yield return new ValidationResult("Você deve concordar com os termos.", new[] { nameof(AgreeTerms) });
            }

            if (!IsValidCpf(Cpf))
            {
                yield return new ValidationResult("CPF inválido.", new[] { nameof(Cpf) });
            }

            if (!IsValidTelefone(Telefone))
            {
                yield return new ValidationResult("Telefone inválido.", new[] { nameof(Telefone) });
            }
        }

        private bool IsValidCpf(string cpf)
        {
            int[] firstMultiplier = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] secondMultiplier = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int sum = 0;

            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * firstMultiplier[i];

            int remainder = sum % 11;
            if (remainder < 2)
                remainder = 0;
            else
                remainder = 11 - remainder;

            string digit = remainder.ToString();
            tempCpf = tempCpf + digit;
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * secondMultiplier[i];

            remainder = sum % 11;
            if (remainder < 2)
                remainder = 0;
            else
                remainder = 11 - remainder;

            digit = digit + remainder.ToString();

            return cpf.EndsWith(digit);
        }

        private bool IsValidTelefone(string telefone)
        {
            // Verifique se o telefone tem o número correto de dígitos
            return telefone.Length >= 8 && telefone.Length <= 11;
        }
    }
}
