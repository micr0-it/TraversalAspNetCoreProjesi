namespace TraversalCoreProject.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Pwd { get; set; }
        public string? ConfirmPwd { get; set; }
        public string? ImgUrl { get; set; }
        public IFormFile? Img { get; set; }
    }
}
