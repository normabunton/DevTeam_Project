using DevTeam_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Console
{
    class ProgramUI
    {

        private DeveloperRepository _contentRepo = new DeveloperRepository();

        public void Run()
        {
            SeedContentList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please register for DevTeams:\n +" +
                    "1. Enter your Unique ID Number:\n" +
                    "2. Enter Your First Name:\n" +
                    "3. Enter Your Last Name:\n" +
                    "4. Do you have access to Pluralsight?:\n" +
                    "5. Enter the Name of your Team:\n" +
                    "6. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayIdNumber();
                        break;
                    case "2":
                        DisplayFirstName();
                        break;
                    case "3":
                        DisplayLastName();
                        break;
                    case "4":
                        DisplayPluralSightAccess();
                        break;
                    case "5":
                        DisplayTeamName();
                        break;
                    case "6":
                        Console.WriteLine("Welcome to the Team!");
                        keepRunning = false;
                        break;
                    case "7":
                        RegisterDeveloper();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid ID Number.");
                        break;
                }
                Console.WriteLine("Please press Enter to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void RegisterDeveloper()
        {
            Console.Clear();
            Developer newContent = new Developer();

            Console.WriteLine("Enter your Unique ID:");
            string idAsString = Console.ReadLine();
            newContent.IdNumber = double.Parse(idAsString);

            Console.WriteLine("Enter your First Name:");
            newContent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            newContent.LastName = Console.ReadLine();

            Console.WriteLine("Do you have Pluralsight Access? (y/n):");
            string pluralSightAccessString = Console.ReadLine().ToLower();
            if (pluralSightAccessString == "y")
            {
                newContent.PluralSightAccess = true;
            }
            else
            {
                newContent.PluralSightAccess = false;
            }

            Console.WriteLine("Enter the Team Number have you been assigned to:\n" +
                                "1. Front End\n" +
                                "2. Back End\n" +
                                "3. Full Stack\n" +
                                "4. Design");
            string teamNameAsString = Console.ReadLine();
            int teamNameAsInt = int.Parse(teamNameAsString);
            newContent.NameOfTeam = (TeamName)teamNameAsInt;

            _contentRepo.AddDeveloperToList(newContent);
        }

        private void DisplayIdNumber()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"IdNumber: {content.IdNumber}\n" +
                                  "FirstName: {content.Firstname}", "LastName: {content.Lastname}\n" +
                                  "PluralsightAccess: {content.PluralSightAccess}\n" +
                                  "TeamName: {content.TeamName}");

            }
        }
        private void DisplayFirstName()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"FirstName: {content.FirstName}");

            }
        }
        private void DisplayLastName()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"LastName: {content.LastName}");
            }
        }
        private void DisplayPluralSightAccess()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"PluralSightAccess: {content.PluralSightAccess}");
            }

            const bool V = false;
            if (!(V))
            {
                Console.WriteLine("You need Acces to PluralSight");
            }
        }
        private void DisplayTeamName()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"TeamName: {content.NameOfTeam}");
            }
        }
        public List<Developer> GetDevelopers()
        {
            return _contentRepo;
        }
        private void gListOfDevelopers()/////list update
        {
            Developer oldContent = _contentRepo.GetContentByIdNumber(OriginalIdNumber);

            Developer newContent = new Developer();

            Console.WriteLine("Enter your Unique ID:");
            string idAsString = Console.ReadLine();
            newContent.IdNumber = double.Parse(idAsString);

            Console.WriteLine("Enter your First Name:");
            newContent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            newContent.LastName = Console.ReadLine();

            Console.WriteLine("Do you have Pluralsight Access? (y/n):");
            string pluralSightAccessString = Console.ReadLine().ToLower();
            if (pluralSightAccessString == "y")
            {
                newContent.PluralSightAccess = true;
            }
            else
            {
                newContent.PluralSightAccess = false;
            }

            Console.WriteLine("Enter the Team Number have you been assigned to:\n" +
                                "1. Front End\n" +
                                "2. Back End\n" +
                                "3. Full Stack\n" +
                                "4. Design");
            string teamNameAsString = Console.ReadLine();
            int teamNameAsInt = int.Parse(teamNameAsString);
            newContent.NameOfTeam = (TeamName)teamNameAsInt;

            _contentRepo.AddDeveloperToList(newContent);
        }

        private void DisplayIdNumber()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"IdNumber: {content.IdNumber}\n" +
                                  "FirstName: {content.Firstname}", "LastName: {content.Lastname}\n" +
                                  "PluralsightAccess: {content.PluralSightAccess}\n" +
                                  "TeamName: {content.TeamName}");
            }
        }
        private void DisplayFirstName()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"FirstName: {content.FirstName}");

            }
        }
        private void DisplayLastName()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"LastName: {content.LastName}");
            }
        }
        private void DisplayPluralSightAccess()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"PluralSightAccess: {content.PluralSightAccess}");
            }

            const bool V = false;
            if (!(V))
            {
                Console.WriteLine("You need Acces to PluralSight");
            }
        }
        private void DisplayTeamName()
        {
            List<Developer> listOfDevelopers = _contentRepo.GetContentList();
            foreach (Developer content in listOfDevelopers)
            {
                Console.WriteLine($"TeamName: {content.NameOfTeam}");
            }
        }
        public List<Developer> GetDevelopers()
        {
            return _contentRepo;
        }

    }
    bool wasUpdated = _contentRepo.UpdateExistingContent(oldDeveloper, newContent);
         if (wasUpdated)
        {
            Console.WriteLine("Content successfully updated!");
        }
         else
{
    Console.WriteLine("Could not update content.");
}


public void DeleteExistingContent()
{
    DisplayAllContent();
    Console.WriteLine("\nEnter the Developer you want to delete:");
    string input = Console.ReadLine();
    bool wasDeleted = _contentRepo.RemoveContentFromList(input);
    if (wasDeleted)
    {
        Console.WriteLine("The Developer was Deleted");
    }
    else
    {
        Console.WriteLine("The Developer was not deleted");
    }
}

        
        private void SeedContentList()
{
    Developer developer1 = new Developer("Norma", "Bunton", 123, true, TeamName.BackEnd);
    Developer developer2 = new Developer("Sylas", "Bunton", 1234, false, TeamName.FrontEnd);
    Developer developer3 = new Developer("Lucy", "Bunton", 12345, true, TeamName.Design);

    _contentRepo.AddDeveloperToList(developer1);
    _contentRepo.AddDeveloperToList(developer2);
    _contentRepo.AddDeveloperToList(developer3);
        
}
    }
}

