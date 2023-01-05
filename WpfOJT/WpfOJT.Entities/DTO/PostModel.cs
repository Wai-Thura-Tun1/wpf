
namespace WpfOJT.Entities.DTO
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Status { get; set; } = "";

        public bool IsPublished { get; set; }

        public DateTime CreatedDate { get; set; }

        public string sCreatedDate { get; set; } = "";

        public string CreatedUserId { get; set; } = "";

        public string CreatedUserName { get; set; } = "";

        public string UpdatedUserId { get; set; } = "";
    }

    public class PostListViewModel
    {
        public int TotalPosts { get; set; }
        public List<PostViewModel> Posts { get; set; }
    }
}
