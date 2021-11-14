using System;
namespace API.Entities{
    public class Student{
        public long Id{get;set;}
        public string Firstname{get;set;}
        public string Lastname{get;set;}
        public string NationalIdNo{get;set;}
        public string Grade{get;set;}
        public string Field{get;set;}
        public string Subfield{get;set;}
        public float Average{get;set;}
        public string UniversityName{get;set;}
        public string UniversityType{get;set;}
        public string UniversityAddress{get;set;}
        public DateTime? StartDate{get;set;}
        public DateTime? EndDate{get;set;}
        public DateTime Created{get;set;} = DateTime.Now;
    }
}