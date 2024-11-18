using System;

namespace ConnnectToSql2
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SexId { get; set; }
        public string SexLabel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}
