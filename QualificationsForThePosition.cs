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

        public Qualification GetQualificationByName(string requirementName)
        {
            var requirement = Qualifications.FirstOrDefault(q => q.Requirements == requirementName);

            return requirement;

        }

        public void ShowQualification(int requirementNumber, Qualification qualification)
        {
            Console.WriteLine($"{requirementNumber}. Requirement Name: {qualification.Requirements}, Weight: {qualification.WeightOfRequirements}");
        }
        public void ShowQualifications(List<Qualification> qualifications)
        {
            int i = 0;
            foreach (Qualification qualification in qualifications)
            {
                i++;
                ShowQualification(i, qualification);
            }
        }
        public void ShowAllQualifications()
        {
            Console.WriteLine("These are all present requirements for the position:");
            ShowQualifications(Qualifications);
        }

        public List<string> GetQualificationsList(List<Qualification> qualifications)
        {
            List<string> list = new List<string>();
            foreach (Qualification qualification in qualifications)
            {
                list.Add(qualification.Requirements);
            }

            return list;
        }
        public List<string> ReturnQualificationsList()
        {
            return GetQualificationsList(Qualifications);
        }
        public List<int> GetQualificationsWeightList(List<Qualification> qualifications)
        {
            List<int> list = new List<int>();
            foreach (Qualification qualification in qualifications)
            {
                list.Add(qualification.WeightOfRequirements);
            }

            return list;
        }
        public List<int> ReturnQualificationsWeightList()
        {
            return GetQualificationsWeightList(Qualifications);
        }

    }
}
