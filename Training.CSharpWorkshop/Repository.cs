using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharpWorkshop
{
    public class Repository
    {
        private readonly List<User> _userList;

        public Repository()
        {
            _userList = GetUsers();
        }

        private List<User> GetUsers()
        {
            var list = new List<User>();

            int i = 0;

            var user = new User();
            user.Id = i++;
            user.Name = "Andrew";
            user.Role = RoleEnum.Admin;

            list.Add(user);

            user = new User();
            user.Id = i++;
            user.Name = "Dave";
            user.Role = RoleEnum.Guest;

            list.Add(user);

            return list;
        }

        public User GetUserByName(string name)
        {
            foreach (var item in _userList)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public User Find(string name)
        {
            return _userList.Find(item => item.Name == name);
        }

        public void Insert(User user)
        {
            // We could add logic to prevent duplicates here.
            // Add logic to add users only if they are in the admin role.
            _userList.Add(user);
        }

        public void Delete(User user)
        {
            // Add logic to remove users only if they are in the admin role.
            _userList.Remove(user);
        }
    }
}
