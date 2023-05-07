using System.ComponentModel.DataAnnotations;
namespace VillaAPI_Web.Models.Dto
{
    public class LoginRequestDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

}
