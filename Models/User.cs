using EntityFrameworkCore.EncryptColumn.Attribute;

namespace GreenThumbProject.Models
{
    public class User
    {
        public int UserId { get; set; } // Primary key. 
        public string UserName { get; set; } = null!;

        public Garden Garden { get; set; } = null!; // Navigation prop.  

        [EncryptColumn] // Triggar mekanismen som krypterar lösenordet. 
        public string Password { get; set; } = null!;
    }
}
