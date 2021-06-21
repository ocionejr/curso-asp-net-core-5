using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RestWithASPNETUdemy.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PostgresqlContext _context;

        public UserRepository(PostgresqlContext context)
        {
            _context = context;
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => (u.userName == user.userName) && (u.password == pass));
        }

        public User ValidateCredentials(string userName)
        {
            return _context.Users.SingleOrDefault(u => (u.userName == userName));
        }

        public bool RevokeToken(string userName)
        {
            var user = _context.Users.SingleOrDefault(u => (u.userName == userName));
            if (user is null) return false;

            user.refreshToken = null;
            _context.SaveChanges();
            return true;
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputeBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputeBytes);
            return BitConverter.ToString(hashedBytes);
        }

        public User RefreshUserInfo(User user)
        {
            if (!_context.Users.Any(u => u.id.Equals(user.id))) return null;

            var result = _context.Users.SingleOrDefault(u => u.id.Equals(user.id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return result;
        }

    }
}
