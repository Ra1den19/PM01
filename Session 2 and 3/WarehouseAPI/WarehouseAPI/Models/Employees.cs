using System.ComponentModel.DataAnnotations;
namespace WarehouseAPI.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
