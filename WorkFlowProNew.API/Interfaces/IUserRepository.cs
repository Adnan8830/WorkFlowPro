using WorkFlowProNew.API.Models;

namespace WorkFlowProNew.API.Interfaces
{
    public interface IUserRepository
    {
        User? GetByUserName(string userName);

        void Add(User user);
    }
}
