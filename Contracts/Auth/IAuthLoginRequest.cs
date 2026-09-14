using System.Text.Json.Serialization;

namespace Dorbit.Identity.Contracts.Auth;

public interface IAuthLoginRequest
{
    [JsonIgnore]
    public string UserAgent { get; set; }
}