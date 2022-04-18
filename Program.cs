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
            var listOfRequirements = new QualificationsForThePosition();

            //Console.WriteLine("Choose the file to work on");
            string filePath = @"D:\Kodowanie\Git Projs\CheckMyCV\Candidates Files";




            int chosenCandidate = 0;

            listOfCandidates.GetCandidatesList(filePath);


            while (go == true)
            {
                Console.Clear();
                MainMenu();
                var officerInput = Console.ReadLine();
                officerInput = InputCheckIfInt(officerInput).ToString();
                switch (officerInput)
                {
                    case "0":
                        BackToMenu();
                        break;
                    case "1":
                        listOfCandidates.ShowAllCandidatesFiles();
                        BackToMenu();
                        break;
                    case "2":
                        Console.WriteLine("Do you want to add job requirements or remove requirements?");
                        Console.WriteLine("How many qualifications we are looking for?");
                        string requirementsNumber = Console.ReadLine();
                        int requirementsNumberInt = InputCheckIfInt(requirementsNumber);
                        BackToMenu();
                        break;

                    case "4":
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
                        BackToMenu();
                        


                        break;
                    case "7":
                        Console.WriteLine("GoodBye");
                        return;

                    default:
                        Console.WriteLine("Wrong number. Out of list of possible options");
                        BackToMenu();
                        break;
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
        static int InputCheckIfInt(string userInput)
        {
            if (int.TryParse(userInput, out int j))
            {
                return j;
            }
            else
            {
                Console.WriteLine("Wrong input. Next time write a number. Press ENTER to continue...");
                Console.ReadLine();
                return 0;
            }
        }

        static void BackToMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Press ENTER or other button on keyboard to continue...");
            Console.ReadLine();
        }


    }

}