using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.user
{
    public class Users 
    {
        public List<User> users { get; set; } = new List<User>();

        public void AddUser(string name, string surname, string password, string email, string description) 
        {   
            User user = new User(name, surname, password, email, description);
            users.Add(user);
        }

        public void DeleteUser(Guid id)
        {
            users.RemoveAll(item => item.Id == id);
        }
    }
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Role { get; set; } = "User";
        
        public User(string name, string surname, string password, string email, string description) 
        { 
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.SurName = surname;
            this.Password = password;
            this.Email = email;
            this.Description = description;
        }
    }
}
