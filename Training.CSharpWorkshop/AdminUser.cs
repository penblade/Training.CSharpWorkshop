namespace Training.CSharpWorkshop
{
    public class AdminUser : User
    {
        public AdminUser()
        {
            Role = RoleEnum.Admin;
        }

        public bool AdminMethodOnly()
        {
            return true;
        }
    }
}
