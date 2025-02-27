using System.ComponentModel.DataAnnotations;
namespace WarehouseAPI.Models
{
    public class Clients
    {
        [Key]
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
    }
}
