using WorkFlowProNew.API.DTOs.Auth;

namespace WorkFlowProNew.API.Interfaces
{
    public interface IAuthService
    {
        LoginResponseDto? Login(LoginRequestDto request);

    }
}
