using System.ComponentModel.DataAnnotations;
namespace WebApi_CargoWeb.Models.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "Por favor digite el nombre de usuario")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "Por favor digite su password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
