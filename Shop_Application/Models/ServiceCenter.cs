
namespace Shop_Application.Models
{
    public class ServiceCenter
    {
        public int Id { get; set; }

        public string Adress { get; set; }

        public string? Phone { get; set; }

        public IQueryable<Employee>? Employees { get; set; }
    }
}
