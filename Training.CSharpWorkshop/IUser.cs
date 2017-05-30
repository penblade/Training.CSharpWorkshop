namespace Training.CSharpWorkshop
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        RoleEnum Role { get; set; }
        bool CanInsert();
        bool CanDelete();
        bool CanFind();
    }
}
