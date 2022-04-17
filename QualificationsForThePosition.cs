using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMyCV
{
    class QualificationsForThePosition
    {
        public List<String> Qualifications { get; set; } = new List<String>();

        public void AddingQualifications(string qualification)
        {
            Qualifications.Add(qualification);
        }


    }
}
