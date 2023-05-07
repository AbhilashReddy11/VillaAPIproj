
using System.ComponentModel.DataAnnotations;
using VillaAPI_Web.Models;

namespace VillaAPI_Web.Models.Dto
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
