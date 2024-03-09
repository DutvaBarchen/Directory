using System.ComponentModel.DataAnnotations;

namespace Directory.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required, MinLength(2), MaxLength(50)]
        public string LastName { get; set; } = null!;

        [Required, StringLength(11)]
        public string PrivateNumber { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [MinLength(4), MaxLength(50)]
        public string? PersonalNumber { get; set; }

        [MinLength(4), MaxLength(50)]
        public string? WorkNumber { get; set; }

        [MinLength(4), MaxLength(50)]
        public string? HomeNumber { get; set; }

        [Required]
        public string City { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        public List<Relationship> Contacts { get; set; } = null!;
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum RelationshipType
    {
        Friend,
        Relative,
        Colleague,
        Other
    }
}
