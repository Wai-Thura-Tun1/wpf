using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfOJT.Entities.Data;

public partial class User
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    public string FirstName { get; set; } = "";

    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; } = "";

    [Required]
    [MaxLength(255)]
    [Column(TypeName = "varchar(255)")]
    public string Email { get; set; } = "";

    [Required]
    [MaxLength(255)]
    [Column(TypeName = "varchar(255)")]
    public string Password { get; set; } = "";

    [Required]
    [MaxLength(20)]
    [Column(TypeName = "varchar(20)")]
    public string PhoneNo { get; set; } = "";

    [Required]
    [MaxLength(255)]
    [Column(TypeName = "varchar(255)")]
    public string Address { get; set; } = "";

    public DateTime? Dob { get; set; }

    [Required]
    public int Role { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [Required]
    public bool IsDeleted { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }

    [Required]
    [MaxLength(255)]
    [Column(TypeName = "varchar(255)")]
    public string CreatedUserId { get; set; } = "";

    public DateTime? UpdatedDate { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string? UpdatedUserId { get; set; }

    public DateTime? DeletedDate { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string? DeletedUserId { get; set; }


}
