using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfOJT.Entities.Data;

public partial class Post
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    [Column(TypeName = "varchar(150)")]
    public string Title { get; set; } = "";

    [Required]
    [MaxLength(255)]
    [Column(TypeName = "varchar(255)")]
    public string Description { get; set; } = "";

    [Required]
    public bool IsPublished { get; set; }

    [Required]
    public bool IsDeleted { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }

    [Required]
    [Column(TypeName = "varchar(255)")]
    public string CreatedUserId { get; set; } = "";

    public DateTime? UpdatedDate { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string? UpdatedUserId { get; set; }

    public DateTime? DeletedDate { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string? DeletedUserId { get; set; }




}
