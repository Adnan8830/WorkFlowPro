using WorkFlowProNew.API.Data;
using WorkFlowProNew.API.Interfaces;
using WorkFlowProNew.API.Models;

namespace WorkFlowProNew.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;

        }
        
        public User? GetByUserName(string userName)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == userName);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);

            _context.SaveChanges();
        }

    }
}
