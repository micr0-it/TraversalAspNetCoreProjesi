using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Girin")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Lütfen Soyadınızı girin")]
        public string Surname { get; set; }
        
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı girin")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage ="Lütfen Mailinizi girin")]
        public string Mail { get; set; }
        
        [Required(ErrorMessage ="Lütfen şifrenizi girin")]
        public string Pwd { get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi tekrar girin")]
        [Compare("Pwd", ErrorMessage ="Aynı şifreyi girmediniz!")]
        public string ConfirmPwd { get; set; }
    }
}
