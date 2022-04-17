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

        public Candidate(int id, string cvFileName, string name, string surName, bool isQualified)
        {
            Id = id;
            CVFileName = cvFileName;
            Name = name;
            SurName = surName;
            IsQualified = isQualified;
        }
        public int Id { get; set; }
        public string CVFileName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsQualified { get; set; }

        //public string CandidateFileName()

    }
}
