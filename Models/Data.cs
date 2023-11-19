using System.ComponentModel.DataAnnotations;

namespace zadanie.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Podaj imię")]
        [MinLength(2, ErrorMessage = "Imię powinno mieć co najmniej 2 znaki")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Podaj Adres e-mail")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj Hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić Hasło")]
        [Compare("Password", ErrorMessage = "Hasła się nie zgadzają")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Podaj Nr telefonu")]
        [MinLength(8, ErrorMessage = "Nieprawidłowy numeru telefonu")]
        public string PhoneNum { get; set; }

        [Required(ErrorMessage = "Podaj Wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10, a 80")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Wybierz Miasto")]
        public string City { get; set; }
        public string? SuccessMessage { get; set; }
    }
}
