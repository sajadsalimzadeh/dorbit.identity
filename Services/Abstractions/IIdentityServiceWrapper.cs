using System.Threading.Tasks;
using Dorbit.Identity.Entities;

namespace Dorbit.Identity.Services.Abstractions;

public interface IIdentityServiceWrapper
{
    Task OnLoginExecutingAsync(UserBase user);
}