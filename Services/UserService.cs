using EFCORE_Demo_Code.Data;
using EFCORE_Demo_Code.Data.Entities;

namespace EFCORE_Demo_Code.Services
{
    internal class UserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int CreateUser(AppUser user)
        {
            _context.Add(user);
            return _context.SaveChanges();
        }
    }

}
