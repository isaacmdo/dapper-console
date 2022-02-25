using Dapper.Contrib.Extensions;

namespace dapper_console_aplication.Models
{
    [Table("[User]")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }

        public string PasswordHash { get; set; }
        
        public string Bio { get; set; }
        
        public string Image { get; set; }
        
        public string Slug { get; set; }
    }
}