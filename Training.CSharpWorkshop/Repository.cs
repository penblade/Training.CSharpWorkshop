using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharpWorkshop
{
    public class Repository
    {
        private readonly List<IUser> _userList;

        public Repository()
        {
            _userList = GetUsers();
        }

        private List<IUser> GetUsers()
        {
            var list = new List<IUser>();

            int i = 0;

            IUser user;

            user = new AdminUser();
            user.Id = i++;
            user.Name = "Andrew";

            list.Add(user);

            user = new GuestUser();
            user.Id = i++;
            user.Name = "Dave";

            list.Add(user);

            return list;
        }

        public IUser GetUserByName(string name)
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

        public IUser Find(string name)
        {
            return _userList.Find(item => item.Name == name);
        }

        public void Insert(IUser user)
        {
            // We could add logic to prevent duplicates here.
            // Add logic to add users only if they are in the admin role.
            _userList.Add(user);
        }

        public void Delete(IUser user)
        {
            // Add logic to remove users only if they are in the admin role.
            _userList.Remove(user);
        }
    }
}
