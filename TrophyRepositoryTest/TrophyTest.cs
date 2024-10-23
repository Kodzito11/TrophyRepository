using TrophyRepository;

namespace TrophyRepositoryTest
{
	[TestClass]
	public class TrophyTest
	{
		[TestMethod]
		public void ToStringTest()
		{
			Trophy trophy = new Trophy
			{ 
			  Id = 1,
			  Competition = "Trophies",
			  Year = 1970 
			};


			string result = trophy.ToString();

			Assert.AreEqual("Id: 1, Competition: Trophies, Year: 1970", result);
		}

		[TestMethod()]
		public void ValidateCompetitionTest()
		{

			Trophy trophy = new Trophy() { Competition = null };
			Assert.ThrowsException<ArgumentNullException>(() => trophy.ValidateCompetition());

			trophy.Competition = "tre";
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateCompetition());

		}

		[TestMethod()]

		public void ValidateYearTest() 
		{

			Trophy trophy = new Trophy() { Year = 1969 };
			Assert.ThrowsException<ArgumentOutOfRangeException>( () => trophy.ValidateYear());

			trophy.Year = 2025;
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateYear());
		
		}
	}
}