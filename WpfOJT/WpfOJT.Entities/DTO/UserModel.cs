
namespace WpfOJT.Entities.DTO
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string FullName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public string PhoneNo { get; set; } = "";

        public string Address { get; set; } = "";

        public bool IsActive { get; set; }

        public int Role { get; set; }

        public string sRole { get; set; } = "";

        public DateTime? Dob { get; set; }

        public string sDob { get; set; } = "";

        public DateTime CreatedDate { get; set; }

        public string sCreatedDate { get; set; } = "";

        public string CreatedUserName { get; set; } = "";

        public string CreatedUserId { get; set; } = "";

        public string UpdateUserId { get; set; } = "";
    }

    public class UserListViewModel
    {
        public int TotalUsers { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}
