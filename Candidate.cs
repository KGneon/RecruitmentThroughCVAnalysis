using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMyCV
{
    class Candidate
    {
        public Candidate(int id, string cvFileName)
        {
            Id = id;
            CVFileName = cvFileName;
            //IsQualified = isQualified;
        }

        public Candidate(int id, string cvFileName, string emailAdress, List<string> qualifications, int qualificationWeightNumber)
        {
            Id = id;
            CVFileName = cvFileName;
            //Name = name;
            //SurName = surName;
            EmailAdress = emailAdress;
            QualificationsByRequired = qualifications;
            QualificationWeightNumber = qualificationWeightNumber;
        }

        public int Id { get; set; }
        public string CVFileName { get; set; }
        //public string Name { get; set; }
        //public string SurName { get; set; }
        public string EmailAdress { get; set; }
        public List<string> QualificationsByRequired { get; set; } = new List<string>();
        public int QualificationWeightNumber { get; set; }
    }
}
