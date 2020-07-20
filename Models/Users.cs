using System;

namespace SheshaAPI.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserCellNumber { get; set; }
        public DateTime UserCreatedDate { get; set; }
        public bool UserActive { get; set; }
    }
}