using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;

namespace CheckMyCV
{
    class CandidatesDataBase
    {
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
        public string[] GetCandidatesList(string filePath)
        {
            string[] candidatesList;
            String candidatesCvDirection = filePath;

            candidatesList = Directory.GetFiles(candidatesCvDirection, "*", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToArray();

            return candidatesList;
        }

        public void ShowCandidateFile(Candidate candidate)
        {
            Console.WriteLine($"ID: {candidate.Id}, CV File Name: {candidate.CVFileName}");
        }
        public void ShowCandidatesFiles(string filePath)
        {

            string[] candidatesList = GetCandidatesList(filePath);
            for (int i = 0; i < candidatesList.Length; i++)
            {
                var candidate = new Candidate(i, candidatesList[i]);
                Candidates.Add(candidate);
                ShowCandidateFile(candidate);
            }

        }

        public string ExtractTextFromPdf(string path, string cv)
        {
            var doc = new Document($@"{path}\{cv}");
            string textTest = doc.ToString();

            return textTest;
        }
        //public void CorrectingFileName(string filePath)

        //public void ShowCandidatesWithQualifications(string filePath)
        //{

        //    string[] candidatesList = GetCandidatesList(filePath);
        //    for (int i = 0; i < candidatesList.Length; i++)
        //    {
        //        var candidate = Candidates.SingleOrDefault(x => x.Id == i);
        //        if (candidate != null)
        //            Candidates.Remove(candidate);


        //        var candidate = new Candidate(i, candidatesList[i], );
        //        Candidates.Add(candidate);
        //        ShowCandidateFile(candidate);
        //    }

        //}
        //public void GetCandidateDataDetails(string cvPath)
        //public void ShowCandidate(Candidate candidate)

    }
}
