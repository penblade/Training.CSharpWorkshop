namespace Training.CSharpWorkshop
{
    public class GuestUser : User
    {
        public GuestUser()
        {
            Role = RoleEnum.Guest;
        }

        public bool GuestMethodOnly()
        {
            return true;
        }

        public override bool CanInsert()
        {
            return true;
        }
    }
}
