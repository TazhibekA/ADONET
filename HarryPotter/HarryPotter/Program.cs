using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Character> characters = new List<Character>();
            List<Faculty> faculties = new List<Faculty>();
            List<Spell> spells = new List<Spell>();

            using (WebClient client = new WebClient())
            {
                characters = JsonConvert.DeserializeObject<List<Character>>(client.DownloadString("https://www.potterapi.com/v1/characters?key=$2a$10$8T3xM.P6jBuSRFq82OgvJOhFV0QDgnxwN07UDn6ZMEAFdBeHeoDXS"));
                faculties = JsonConvert.DeserializeObject<List<Faculty>>(client.DownloadString("https://www.potterapi.com/v1/houses?key=$2a$10$8T3xM.P6jBuSRFq82OgvJOhFV0QDgnxwN07UDn6ZMEAFdBeHeoDXS"));
                spells = JsonConvert.DeserializeObject<List<Spell>>(client.DownloadString("https://www.potterapi.com/v1/spells?key=$2a$10$8T3xM.P6jBuSRFq82OgvJOhFV0QDgnxwN07UDn6ZMEAFdBeHeoDXS"));
            }
            while (true)
            {
                string choose;
                Console.WriteLine("1 - Show characters");
                Console.WriteLine("2 - Show houses ");
                Console.WriteLine("3 - Show spells ");
                Console.WriteLine("4 - Sorting Hat ");

                Console.WriteLine("Choose: ");
                choose = Console.ReadLine();
                int chooseInt = int.Parse(choose);
                switch (chooseInt)
                {
                    case 1:
                        ShowCharacter(characters);
                        break;
                    case 2:
                        ShowFaculty(faculties);
                        break;
                    case 3:
                        ShowSpells(spells);
                        break;
                    case 4:
                        SortingHat();
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

            }

        }

        public static void ShowCharacter(List<Character> characters) {
          
                string chooseCharacter;
                for (int i = 0; i < characters.Count; i++)
                {
                    Console.WriteLine(i + ". " + characters[i].Name);
                }
            while (true)
            {
                Console.WriteLine("Choose character(number): ");
                chooseCharacter = Console.ReadLine();
                int chooseCharacterInt = int.Parse(chooseCharacter);
                for (int i = 0; i < characters.Count; i++)
                {
                    if (i == chooseCharacterInt)
                    {
                        Console.WriteLine("Id: " + characters[i].Id);
                        Console.WriteLine("Name: " + characters[i].Name);
                        Console.WriteLine("Role: " + characters[i].Role);
                        Console.WriteLine("House: " + characters[i].House);
                        Console.WriteLine("School: " + characters[i].School);
                        Console.WriteLine("V: " + characters[i].V);
                        Console.WriteLine("Ministry Of Magic: " + characters[i].MinistryOfMagic);
                        Console.WriteLine("OrderOf The Phoenix: " + characters[i].OrderOfThePhoenix);
                        Console.WriteLine("Dumbledores Army: " + characters[i].DumbledoresArmy);
                        Console.WriteLine("Death Eater: " + characters[i].DeathEater);
                        Console.WriteLine("Blood Status: " + characters[i].BloodStatus);
                        Console.WriteLine("Species: " + characters[i].Species);

                    }
                }
                string choose;
                Console.WriteLine("1 - Continue");
                Console.WriteLine("2 - Exit ");


                Console.WriteLine("Choose: ");
                choose = Console.ReadLine();
                int chooseInt = int.Parse(choose);
                if (chooseInt == 2)
                {
                    Console.Clear();
                    break;
                }
                else if (chooseInt == 1) {
                }
                else { Console.WriteLine("Error"); }
            }
            return;
        }

        public static void ShowFaculty(List<Faculty> faculties)
        {
          
                string chooseFaculty;
                for (int i = 0; i < faculties.Count; i++)
                {
                    Console.WriteLine(i + ". " + faculties[i].Name);
                }
            while (true)
            {
                Console.WriteLine("Choose faculty(number): ");
                chooseFaculty = Console.ReadLine();
                int chooseFacultyInt = int.Parse(chooseFaculty);
                for (int i = 0; i < faculties.Count; i++)
                {
                    if (i == chooseFacultyInt)
                    {
                        Console.WriteLine("Id: " + faculties[i].Id);
                        Console.WriteLine("Name: " + faculties[i].Name);
                        Console.WriteLine("Mascot: " + faculties[i].Mascot);
                        Console.WriteLine("Head Of House: " + faculties[i].HeadOfHouse);
                        Console.WriteLine("School: " + faculties[i].School);
                        Console.WriteLine("House Ghost: " + faculties[i].HouseGhost);
                        Console.WriteLine("Founder: " + faculties[i].Founder);
                        Console.WriteLine("V: " + faculties[i].V);
                        Console.WriteLine("School: " + faculties[i].School);
                        Console.WriteLine("Members: " + faculties[i].Members);
                        Console.WriteLine("Values: " + faculties[i].Values);
                        Console.WriteLine("Colors: " + faculties[i].Colors);

                    }
                }
                string choose;
                Console.WriteLine("1 - Continue");
                Console.WriteLine("2 - Exit ");


                Console.WriteLine("Choose: ");
                choose = Console.ReadLine();
                int chooseInt = int.Parse(choose);
                if (chooseInt == 2)
                {
                    Console.Clear();
                    break;
                }

                else if (chooseInt == 1)
                {
                }


                else { Console.WriteLine("Error"); }
            }
            return;
        }

        public static void ShowSpells(List<Spell> spells)
        {
            
                string chooseSpell;
                for (int i = 0; i < spells.Count; i++)
                {
                    Console.WriteLine(i + ". " + spells[i].SpellName);
                }
            while (true)
            {
                Console.WriteLine("Choose spell(number): ");
                chooseSpell = Console.ReadLine();
                int chooseSpellInt = int.Parse(chooseSpell);

                for (int i = 0; i < spells.Count; i++)
                {
                    if (i == chooseSpellInt)
                    {
                        Console.WriteLine("Id: " + spells[i].Id);
                        Console.WriteLine("Name: " + spells[i].SpellName);
                        Console.WriteLine("Type: " + spells[i].Type);
                        Console.WriteLine("Effect: " + spells[i].Effect);


                    }
                }

                string choose;
                Console.WriteLine("1 - Continue");
                Console.WriteLine("2 - Exit ");


                Console.WriteLine("Choose: ");
                choose = Console.ReadLine();
                int chooseInt = int.Parse(choose);
                if (chooseInt == 2)
                {
                    Console.Clear();
                    break;
                }
                else if (chooseInt == 1)
                {
                }

                else { Console.WriteLine("Error"); }
            }
            return;
        }

        public static void SortingHat()
        {
            while (true)
            {
                using (WebClient client = new WebClient())
                {
                    string hat = client.DownloadString("https://www.potterapi.com/v1/sortingHat");
                    Console.WriteLine("Your faculty: " + hat);
                }
                string choose;
                Console.WriteLine("1 - Continue");
                Console.WriteLine("2 - Exit ");
            

                Console.WriteLine("Choose: ");
                choose = Console.ReadLine();
                int chooseInt = int.Parse(choose);
                if (chooseInt == 2)
                {
                    Console.Clear();
                    break;
                }
                else if (chooseInt == 1)
                {
                }

                else { Console.WriteLine("Error"); }
            }
            return;
        }
    }
}
