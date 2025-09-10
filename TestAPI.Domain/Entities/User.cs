namespace TestAPI.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string UserName { get; set; }
        public required string Login { get; set; }
    }
}
