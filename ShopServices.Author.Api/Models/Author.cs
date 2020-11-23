namespace ShopServices.Author.Api.Models
{
    using System;
    using System.Collections.Generic;

    public class Author
    {
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<AcademicDegree> AcademicDegrees { get; set; }

        public string AuthorGuid { get; set; }
        
        public Author()
        {
            AcademicDegrees = new HashSet<AcademicDegree>();
        }
    }
}