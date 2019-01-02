using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPWEB_Residual.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }

        //[Display(Name = "Nome")]
        //[StringLength(32)]
        //[Required(ErrorMessage = "Nome obrigatório!")]
        //public string Nome { get; set; }

        //[Display(Name = "Apelido")]
        //[StringLength(32)]
        //[Required(ErrorMessage = "Apelido obrigatório!")]
        //public string Apelido { get; set; }

        //[Display(Name = "Morada")]
        //[StringLength(256)]
        //[Required(ErrorMessage = "Morada obrigatório!")]
        //public string Morada { get; set; }

        //[Display(Name = "Localidade")]
        //[StringLength(256)]
        //[Required(ErrorMessage = "Localidade obrigatório!")]
        //public string Localidade { get; set; }

        //[Display(Name = "Data de Nascimento")]
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{HH:mm:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public System.DateTime DataNascimento { get; set; }

        //[Display(Name = "Bilhete de Identidade ou Cartão de Cidadão")]
        //[StringLength(8, MinimumLength = 4)]
        //[Required(ErrorMessage = "Bilhete de Identidade ou Cartão de Cidadão obrigatório!")]
        ////[RegularExpression(@"^\(?!00000000)[0-9]{8} \d{1}[0-9] \s{3}[A-Z]?$", ErrorMessage = "Bilhete de Identidade ou Cartão de Cidadão inválido!")]// formato: 43211234 3 ABY -> verificar se está correcto??
        //public string BI_CC { get; set; }

        //[Display(Name = "Número fiscal")]
        //[Required(ErrorMessage = "Número fiscal obrigatório!")]
        ////[RegularExpression(@"^\(?!000000000)[0-9]{9,9}?$", ErrorMessage = "Número fiscal inválido!")] // formato: 123123123 -> não aceita: 000000000
        //public int NIF { get; set; }

        //[Display(Name = "Código postal")]
        //[StringLength(8, MinimumLength = 4)]
        //[Required(ErrorMessage = "Código postal obrigatório!")]
        ////[RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        ////[RegularExpression(@"^\d{4}(-\d{3})?$", ErrorMessage = "Código postal inválido!")]
        ////[RegularExpression(@"^(?!0000)[0-9]{4,4}$", ErrorMessage = "error Message")]
        ////[RegularExpression(@"^\(?!0000)[0-9]{4,4}(-\(?!000)[0-9]{3,3})?$", ErrorMessage = "Código postal inválido!")] // formato : 3000-123 ou 3000 -> não aceita 0000-00 ou 0000
        //public string CodigoPostal { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
