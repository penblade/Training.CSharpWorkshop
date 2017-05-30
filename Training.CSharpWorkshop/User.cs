using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharpWorkshop
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleEnum Role { get; set; }
    }

    namespace Training.CSharpWorkshop
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public RoleEnum Role { get; set; }

            public virtual bool CanInsert()
            {
                return Role == RoleEnum.Admin;
            }

            public bool CanDelete()
            {
                return Role == RoleEnum.Admin;
            }

            public bool CanFind()
            {
                return Role != RoleEnum.None;
            }
        }
    }
}