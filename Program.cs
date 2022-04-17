using System;
using System.IO;
using Aspose.Words;

namespace CheckMyCV
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;

            
            var listOfCandidates = new CandidatesDataBase();
            var listOfQualifications = new QualificationsForThePosition();

            //Console.WriteLine("Choose the file to work on");
            string filePath = @"D:\Kodowanie\Git Projs\CheckMyCV\Candidates Files";




            int chosenCandidate = 0;

            listOfCandidates.GetCandidatesList(filePath);


            while (go == true)
            {
                Console.Clear();
                MainMenu();
                var officerInput = Console.ReadLine();
                switch (officerInput)
                {
                    case "1":
                        //string filePath = @"D:\Kodowanie\Git Projs\CheckMyCV\Candidates Files";
                        listOfCandidates.ShowAllCandidatesFiles();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("How many qualifications we are looking for?");
                        string qualificationsNumber = Console.ReadLine();
                        int qualificationsNumberInt;
                        if (int.TryParse(qualificationsNumber, out int j))
                        {
                            qualificationsNumberInt = j;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadLine();
                            break;
                        }
                        for (int i = 0; i < qualificationsNumberInt; i++)
                        {
                            string q = Console.ReadLine();
                            listOfQualifications.AddingQualifications(q);

                            //Console.WriteLine(listOfQualifications.Qualifications[i]);
                        }
                        break;

                        case"4":
                        Console.WriteLine("Wybierz plik do odczytania 1-2");
                        string userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out int choiceOfCandidate))
                        {
                            chosenCandidate = choiceOfCandidate;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                            Console.ReadLine();
                            break;
                        }
                        string fileName = listOfCandidates.GetCandidateFileNameById(chosenCandidate);
                        Console.WriteLine(fileName);
                        string fullTextFromPdfFile = listOfCandidates.ExtractTextFromPdf(filePath, fileName, chosenCandidate);
                        Console.Clear();
                        Console.WriteLine(fullTextFromPdfFile);
                        Console.WriteLine("Finished");
                        Console.ReadLine();


                        break;

                    default:
                        Console.WriteLine("bye");
                        Console.ReadLine();
                        return;
                }

            }
            //var listOfCandidates = new CandidatesDataBase();

        }

        static void MainMenu()
        {
            Console.WriteLine("Hello HR Officer! I will help you find the right candidate!");

            Console.WriteLine("What do you want to do?");

            Console.WriteLine("1. Show me all candidates.");
            Console.WriteLine("2. Let me determine the necessary qualifications for the position.");
            //Console.WriteLine("3. Show me the list of candidates with their qualifications.");
            Console.WriteLine("4. Show me specific pdf file text");
            //Console.WriteLine("5. Show me the list of qualified candidates.");
            //Console.WriteLine("6. Show me the list of qualified candidates.");
            Console.WriteLine("7. Close the application.");
        }


    }


}