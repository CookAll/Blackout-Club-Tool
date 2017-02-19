using System.Security.Cryptography;
using System.IO;


namespace BRAPI
{
	public class player
	{

        
            public string Id { get; set; }
            public string TeamId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Birthday { get; set; }
            public string Hand { get; set; }
            public string Foot { get; set; }
            public string Nationality { get; set; }
            public string Csr { get; set; }
            public string Salary { get; set; }
            public int Form { get; set; }
            public string Aggression { get; set; }
            public string Discipline { get; set; }
            public int Energy { get; set; }
            public string Leadership { get; set; }
            public string Experience { get; set; }
            public string Weight { get; set; }
            public string Height { get; set; }
            public string Youthid { get; set; }
            public string DualNationality { get; set; }
            public string Name { get; set; }
            public string Injured { get; set; }
            public string Joined { get; set; }
            public string Scouted { get; set; }
            public string Forsale { get; set; }
            public string Listed { get; set; }
            public string Deadline { get; set; }
            public string AskingPrice { get; set; }
            public string Price { get; set; }
            public string BidTeamId { get; set; }
            public string NextBid { get; set; }

            public int Stamina { get; set; }
            public int Handling { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Technique { get; set; }
            public int Strength { get; set; }
            public int Jumping { get; set; }
            public int Speed { get; set; }
            public int Agility { get; set; }
            public int Kicking { get; set; }

            public float Fatness { get; set; }

            public string ScoutingStars { get; set; }
        }

        
            

       
        
    



		
	
	public class team
	{
		public string Id { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
		public string RegionId { get; set; }
		public string StadiumName { get; set; }
        public string IsBot { get; set; } 
        public string Nickname1 { get; set; }
        public string Nickname2 { get; set; }
        public string Nickname3 { get; set; }
        public string RankingPoints { get; set; }
        public string RegionalRank { get; set; }
        public string NationalRank { get; set; }
        public string WorldRank { get; set; }

		public string PrevRankingPoints { get; set; }
		public string PrevRegionalRank { get; set; }
		public string PrevNationalRank { get; set; }
		public string PrevWorldRank { get; set; }
		public string Plural { get; set; }
		public string PluralNickname1 { get; set; }
		public string PluralNickname2 { get; set; }
		public string PluralNickname3 { get; set; }
		public string MinimumSalary { get; set; }
		public string LeagueId { get; set; }
		public string Manager { get; set; }

        public string countryList(string input)
        {
            switch (input)
            {
                case "AR":
                    input = "Argentina";
                    break;
                case "AU":
                    input = "Australia";
                    break;
                case "BE":
                    input = "Belgium";
                    break;
                case "BR":
                    input = "Brazil";
                    break;
                case "CA":
                    input = "Canada";
                    break;
                case "HR":
                    input = "Croatia";
                    break;
                case "CZ":
                    input = "Czech Republic";
                    break;
                case "EN":
                    input = "England";
                    break;
                case "FR":
                    input = "France";
                    break;
                case "GE":
                    input = "Georgia";
                    break;
                case "DE":
                    input = "Germany";
                    break;
                case "HK":
                    input = "Hong Kong";
                    break;
                case "IE":
                    input = "Ireland";
                    break;
                case "IT":
                    input = "Italy";
                    break;
                case "CI":
                    input = "Ivory Coast";
                    break;
                case "JP":
                    input = "Japan";
                    break;
                case "KE":
                    input = "Kenya";
                    break;
                case "NA":
                    input = "Namibia";
                    break;
                case "NL":
                    input = "Netherlands";
                    break;
                case "NZ":
                    input = "New Zealand";
                    break;
                case "PI":
                    input = "Pasific Islands";
                    break;
                case "PL":
                    input = "Poland";
                    break;
                case "PT":
                    input = "Portugal";
                    break;
                case "RO":
                    input = "Romania";
                    break;
                case "RU":
                    input = "Russia";
                    break;
                case "SL":
                    input = "Scotland";
                    break;
                case "ZA":
                    input = "South Africa";
                    break;
                case "ES":
                    input = "Spain";
                    break;
                case "US":
                    input = "UNited States";
                    break;
                case "UY":
                    input = "Uruguay";
                    break;
                case "WA":
                    input = "Wales";
                    break;
                case "ZW":
                    input = "Zimbabwe";
                    break;
                default:
                    return "Could Not Find Country";


            }

            return input;
        }

    }

    public class manager
    {
        public string Season { get; set; }
        public string Round { get; set; }
        public string Day { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string LastClick { get; set; }
        public string LastLogin { get; set; }
        public string DateRegistered { get; set; }
		public string Active { get; set; }
		public string MainTeamId { get; set;  }
		public string Premium { get; set; }
	}






   
    


}