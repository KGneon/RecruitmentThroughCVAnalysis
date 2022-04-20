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
            int chosenCandidate = 0;
            // !!! different location - it depends on machine you are working on
            string filePath = @"Candidates Files";

            var listOfCandidates = new CandidatesDataBase();
            var listOfRequirements = new QualificationsForThePosition();

            listOfCandidates.GetCandidatesList(filePath);

            while (go == true)
            {
                Console.Clear();
                MainMenu();
                var officerInput = Console.ReadLine();
                officerInput = InputCheckIfInt(officerInput).ToString();

                switch (officerInput)
                {
                    case "1":
                        listOfCandidates.ShowAllCandidatesFiles();
                        BackToMenu();
                        break;

                    case "2":
                        listOfCandidates.ShowAllCandidatesFiles();
                        Console.WriteLine("");
                        Console.WriteLine("Choose candidate by Id number:");
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
                        Console.WriteLine("Wait for it...");
                        string fullTextFromPdfFile = listOfCandidates.ExtractTextFromPdf(filePath, fileName, chosenCandidate);
                        Console.Clear();
                        Console.WriteLine(fileName);
                        Console.WriteLine("contains...");
                        Console.WriteLine(fullTextFromPdfFile);

                        BackToMenu();
                        break;

                    case "3":
                        Console.WriteLine("Do you want to add job requirements or remove requirements? Add: 1 / Remove: 2");
                        string userNumber = Console.ReadLine();
                        int userNumberInt = InputCheckIfInt(userNumber);
                        if (userNumberInt == 1)
                        {
                            Console.WriteLine("How many qualifications you want to add?");
                            string requirementsNumber = Console.ReadLine();
                            int requirementsNumberInt = InputCheckIfInt(requirementsNumber);

                            Console.WriteLine("Do you want to add importance (weight) of requirements higher than 1? Yes: 1 / No: 2");
                            string userChoiceOfWeight = Console.ReadLine();
                            int userChoiceOfWeightInt = InputCheckIfInt(userChoiceOfWeight);

                            for (int i = 0; i < requirementsNumberInt; i++)
                            {
                                Console.WriteLine($"What is the name of the {i + 1} requirement?");
                                string requirementName = Console.ReadLine();
                                int weightOfRequirementInt;
                                if (userChoiceOfWeightInt == 1)
                                {
                                    Console.WriteLine($"What is the weight of the {i + 1} requirement?");
                                    string weightOfRequirement = Console.ReadLine();
                                    weightOfRequirementInt = InputCheckIfInt(weightOfRequirement);
                                }
                                else
                                {
                                    weightOfRequirementInt = 1; 
                                }

                                var requirement = new Qualification(weightOfRequirementInt, requirementName);
                                listOfRequirements.AddingQualifications(requirement);

                            }

                        }
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
        }
        static void MainMenu()
        {
            Console.WriteLine("Hello HR Officer! I will help you find the right candidate!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("");
            Console.WriteLine("1. Show me all candidates.");
            Console.WriteLine("2. Show me specific cadidate pdf file text");
            Console.WriteLine("3. Let me determine the necessary qualifications for the position.");
            //Console.WriteLine("4. Show me the list of candidates with their qualifications.");
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