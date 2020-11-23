namespace ShopServices.Author.Api.Models
{
    using System;
    
    public class AcademicDegree
    {
        public int AcademicDegreeId { get; set; }

        public string Name { get; set; }

        public string AcademicCenter { get; set; }

        public DateTime? AcademicDegreeDate { get; set; }

        public string AcademicDegreeGuid { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}