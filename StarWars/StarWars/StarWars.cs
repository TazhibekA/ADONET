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

namespace StarWars
{
    public class StarWars
    {
        public List<Person> People { get; set; }
        public List<Planet> Planets { get; set; }
        public List<Starship> Starships { get; set; }
        public List<KeyValuePair<int, int>> PeopleToStarships { get; set; }
        public List<KeyValuePair<int, int>> PeopleToPlanets { get; set; }

        public StarWars()
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager
                                           .ConnectionStrings["StarWarsConnectionStrings"]
                                           .ConnectionString;
                connection.Open();

                var peopleCreateCommand = new SqlCommand();
                peopleCreateCommand.Connection = connection;
                peopleCreateCommand.CommandText = "create table People (  [Id]  INT    NOT NULL," +
    "[name]       NVARCHAR(MAX) NULL," +
    "[height] NVARCHAR(MAX) NULL," +
    "[mass] NVARCHAR(MAX) NULL," +
    "[hair_color] NVARCHAR(MAX) NULL," +
    "[skin_color] NVARCHAR(MAX) NULL," +
    "[eye_color] NVARCHAR(MAX) NULL," +
    "[birth_year] NVARCHAR(MAX) NULL," +
   " [gender] NVARCHAR(MAX) NULL," +
    "[homeworld] NVARCHAR(MAX) NULL," +
     "[created]  NVARCHAR (MAX) NULL," +
    "[edited]  NVARCHAR (MAX) NULL," +
    "[url] NVARCHAR(MAX) NULL," +
                 "); ";
                peopleCreateCommand.ExecuteNonQuery();


                var planetsCreateCommand = new SqlCommand();
                planetsCreateCommand.Connection = connection;
                planetsCreateCommand.CommandText = "create table Planets(" +
                    "    [Id]              INT           NOT NULL," +
                    "    [name]            NVARCHAR (MAX) NULL," +
                    "    [rotation_period] NVARCHAR (MAX) NULL," +
                    "    [orbital_period]  NVARCHAR (MAX) NULL," +
                    "    [diameter]        NVARCHAR (MAX) NULL," +
                    "    [climate]         NVARCHAR (MAX) NULL," +
                    "    [gravity]         NVARCHAR (MAX) NULL," +
                    "    [terrain]         NVARCHAR (MAX) NULL," +
                    "    [surface_water]   NVARCHAR (MAX) NULL," +
                    "    [population]      NVARCHAR (MAX) NULL," +
                     "    [created]         NVARCHAR (MAX) NULL," +
                    "    [edited]           NVARCHAR (MAX) NULL," +
                    "    [url]             NVARCHAR (MAX) NULL," +
                     "); ";
                planetsCreateCommand.ExecuteNonQuery();



                var starshipsCreateCommand = new SqlCommand();
                starshipsCreateCommand.Connection = connection;
                starshipsCreateCommand.CommandText = "create table Starships(" +
                    "    [Id]                     INT        NOT NULL," +
                    "    [name]                   NVARCHAR (MAX) NULL," +
                    "    [model]                  NVARCHAR (MAX) NULL," +
                    "    [manufacturer]           NVARCHAR (MAX) NULL," +
                    "    [cost_in_credits]        NVARCHAR (MAX) NULL," +
                    "    [length]                 NVARCHAR (MAX) NULL," +
                    "    [max_atmosphering_speed] NVARCHAR (MAX) NULL," +
                    "    [crew]                   NVARCHAR (MAX) NULL," +
                    "    [passengers]             NVARCHAR (MAX) NULL," +
                    "    [cargo_capacity]         NVARCHAR (MAX) NULL," +
                    "    [consumables]            NVARCHAR (MAX) NULL," +
                    "    [hyperdrive_rating]      NVARCHAR (MAX) NULL," +
                    "    [MGLT]                   NVARCHAR (MAX) NULL," +
                    "    [starship_class]         NVARCHAR (MAX) NULL," +
                     "    [created]               NVARCHAR (MAX) NULL," +
                    "    [edited]                 NVARCHAR (MAX) NULL," +
                    "    [url]                    NVARCHAR (MAX) NULL," +
                     ");";
                starshipsCreateCommand.ExecuteNonQuery();


                var peopleToStarshipsCreateCommand = new SqlCommand();
                peopleToStarshipsCreateCommand.Connection = connection;
                peopleToStarshipsCreateCommand.CommandText = "create table PeopleToStarships(" +
                    "PersonID int NOT NULL ," +
                    "[StarshipID]  int NOT NULL" +
                    ");";

                peopleToStarshipsCreateCommand.ExecuteNonQuery();


                var peopleToPlanetsCreateCommand = new SqlCommand();
                peopleToPlanetsCreateCommand.Connection = connection;
                peopleToPlanetsCreateCommand.CommandText = "create table PeopleToPlanets(" +
                    "PersonID int  NOT NULL," +
                    "[PlanetID]  int NOT NULL" +
                    ");";

                peopleToPlanetsCreateCommand.ExecuteNonQuery();

            }
            AddInfo();
        }

        public void AddInfo()
        {
            PeopleToStarships = new List<KeyValuePair<int, int>>();
            PeopleToPlanets = new List<KeyValuePair<int, int>>();
            People = new List<Person>();
            Planets = new List<Planet>();
            Starships = new List<Starship>();


            using (WebClient client = new WebClient())
            {
                string url = "https://swapi.co/api/people/?page=1&format=json";
                while (url != string.Empty)
                {
                    JObject json = JObject.Parse(client.DownloadString(url));
                    People.AddRange(JsonConvert.DeserializeObject<List<Person>>(json.GetValue("results").ToString()));
                    url = json.GetValue("next").ToString();

                }
                url = "https://swapi.co/api/planets/?format=json";
                while (url != string.Empty)
                {
                    JObject json = JObject.Parse(client.DownloadString(url));
                    Planets.AddRange(JsonConvert.DeserializeObject<List<Planet>>(json.GetValue("results").ToString()));
                    url = json.GetValue("next").ToString();

                }
                url = "https://swapi.co/api/starships/?format=json";
                while (url != string.Empty)
                {
                    JObject json = JObject.Parse(client.DownloadString(url));
                    Starships.AddRange(JsonConvert.DeserializeObject<List<Starship>>(json.GetValue("results").ToString()));
                    url = json.GetValue("next").ToString();
                    Console.WriteLine("Downloaded starships...");
                }
                AddId();
                AddConnections();
            }

        }


        public void AddId()
        {
            foreach (var item in People)
            {
                item.SetId();
            }
            foreach (var item in Starships)
            {
                item.SetId();
            }
            foreach (var item in Planets)
            {
                item.SetId();
            }
        }


        public void AddConnections()
        {
            foreach (var item in Starships)
            {
                var pilots = item.Pilots;
                for (int i = 0; i < pilots.Count; i++)
                {
                    PeopleToStarships.Add(new KeyValuePair<int, int>(People.Where(a => a.Url == pilots[i]).First().Id, item.Id));
                } //PeopleToStarships
            }

            foreach (var item in Planets)
            {
                var residents = item.Residents;
                for (int i = 0; i < residents.Count; i++)
                {
                    PeopleToPlanets.Add(new KeyValuePair<int, int>(People.Where(a => a.Url == residents[i]).First().Id, item.Id));
                } //PeopleToPlanets
            }
        }
        public void LoadDb()
        {
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["StarWarsConnectionStrings"].ProviderName);

            using (var connection = dbProviderFactory.CreateConnection())
            {


                connection.ConnectionString = ConfigurationManager
                                                .ConnectionStrings["StarWarsConnectionStrings"]
                                                .ConnectionString;
                connection.Open();





                var insertPeople = connection.CreateCommand();
                insertPeople.Connection = connection;
                foreach (var item in People)
                {
                    insertPeople.CommandText = $"INSERT INTO People " +
                    $"VALUES(" +
                    $"'{item.Id}', " +
                    $"'{item.Name}', " +
                    $"'{item.Height}'," +
                    $"'{item.Mass}'," +
                    $"'{item.HairColor}'," +
                    $"'{item.SkinColor}'," +
                    $"'{item.EyeColor}'," +
                    $"'{item.BirthYear}'," +
                    $"'{item.Gender}'," +
                    $"'{item.Homeworld}'," +
                    $"'{item.Created.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                    $"'{item.Edited.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                    $"'{item.Url}')";
                    insertPeople.ExecuteNonQuery();
                    Console.WriteLine("Downloaded people...");
                }



                var insertStarships = connection.CreateCommand();
                insertStarships.Connection = connection;
                foreach (var item in Starships)
                {
                    insertStarships.CommandText = $"INSERT INTO Starships " +
                    $"VALUES(" +
                     $"'{item.Id}', " +
                    $"'{item.Name}', " +
                    $"'{item.Model}'," +
                    $"'{item.Manufacturer}'," +
                    $"'{item.Consumables}'," +
                    $"'{item.Length}'," +
                    $"'{item.MaxAtmospheringSpeed}'," +
                    $"'{item.Crew}'," +
                    $"'{item.Passengers}'," +
                    $"'{item.CargoCapacity}'," +
                    $"'{item.Consumables}'," +
                    $"'{item.HyperdriveRating}'," +
                    $"'{item.MGLT}'," +
                    $"'{item.StarshipClass}'," +
                    $"'{item.Created.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                    $"'{item.Edited.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                    $"'{item.Url}')";
                    insertStarships.ExecuteNonQuery();
                    Console.WriteLine("Downloaded starships...");

                }



                var insertPlanets = connection.CreateCommand();
                insertPlanets.Connection = connection;
                foreach (var item in Planets)
                {
                    insertPlanets.CommandText = $"INSERT INTO Planets " +
                    $"VALUES(" +
                       $"'{item.Id}', " +
                    $"'{item.Name}', " +
                    $"'{item.RotationPeriod}'," +
                    $"'{item.OrbitalPeriod}'," +
                    $"'{item.Diameter}'," +
                    $"'{item.Climate}'," +
                    $"'{item.Gravity}'," +
                    $"'{item.Terrain}'," +
                    $"'{item.SurfaceWater}'," +
                    $"'{item.Population}'," +
                    $"'{item.Created.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                    $"'{item.Edited.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                    $"'{item.Url}')";
                    insertPlanets.ExecuteNonQuery();
                    Console.WriteLine("Downloaded planets...");
                }




                var peopleToStarships = connection.CreateCommand();
                peopleToStarships.Connection = connection;
                foreach (var item in PeopleToStarships)
                {
                    insertPlanets.CommandText = $"INSERT INTO PeopleToStarships " +
                    $"VALUES(" +
                    $"'{item.Key}', " +
                    $"'{item.Value}')";
                    insertPlanets.ExecuteNonQuery();
                }

                var peopleToPlanets = connection.CreateCommand();
                peopleToPlanets.Connection = connection;
                foreach (var item in PeopleToPlanets)
                {
                    insertPlanets.CommandText = $"INSERT INTO PeopleToPlanets " +
                    $"VALUES(" +
                    $"'{item.Key}', " +
                    $"'{item.Value}')";
                    insertPlanets.ExecuteNonQuery();
                }


            }

        }
    }
}
