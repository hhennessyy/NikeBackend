using System.Text.Json.Serialization;
using Dominio.Entities;

namespace API.Dtos;
public class DataUserDto : BaseEntity
{

    public string Message { get; set; }
    public bool IsAuthenticated { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public List<string> Rols { get; set; }
    public string Token { get; set; }

    [JsonIgnore] // ->this attribute restricts the property to be shown in the result
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiration { get; set; }        
}
