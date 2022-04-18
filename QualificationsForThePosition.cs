using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMyCV
{
    class QualificationsForThePosition
    {
        public List<Qualification> Qualifications { get; set; } = new List<Qualification>();

        public void AddingQualifications(Qualification qualification)
        {
            Qualifications.Add(qualification);
        }

        public void RemoveQualifications(Qualification qualification)
        {
            Qualifications.Remove(qualification);
        }




    }
}
