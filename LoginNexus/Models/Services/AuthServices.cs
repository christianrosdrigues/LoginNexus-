using System.Collections.Generic;
using System.Linq;
using LoginNexus.Models;

namespace LoginNexus.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "ana@nexus.edu", Password = "123", Role = "Pedreira", Name = "Ana do concreto" },
        new User { Email = "aluno@nexus.edu", Password = "123", Role = "Student", Name = "Estudante 01" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
