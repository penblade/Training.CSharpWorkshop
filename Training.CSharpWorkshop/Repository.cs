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

            list.Add(user);

            user = new User();
            user.Id = i++;
            user.Name = "Dave";

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
    }
}
