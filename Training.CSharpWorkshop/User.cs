namespace Training.CSharpWorkshop
{
    public abstract class User : IUser
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
