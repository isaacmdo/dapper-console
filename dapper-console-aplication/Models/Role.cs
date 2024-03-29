using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace dapper_console_aplication.Models
{
    [Table("[Role]")]
    public class Role
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Slug { get; set; }

    }
}