using System.ComponentModel.DataAnnotations;

namespace PrepareAnExam.Web.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçemezsiniz!")]
        [StringLength(maximumLength: 20, MinimumLength = 3,
            ErrorMessage = "Kullanıcı adı minimum 3 maksimum 20 karekter olabilir!")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi boş geçemezsiniz!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
