using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Pwd { get; set; }

    }
}
