using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {

        [Required(ErrorMessage ="E-mail zorunlu bir alan")]
        public String? Email { get; set; } = String.Empty; //String? soru işareti boş olabilir demek

        [Required(ErrorMessage ="FirstName zorunlu bir alan")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage ="LastName zorunlu bir alan")]
        public String? LastName { get; set; } = String.Empty;

        public String FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt= DateTime.Now;
        }
}
}