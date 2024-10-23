using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrophyRepository;
namespace TrophyRepositoryTest
{
	[TestClass]
	public class TrophyRepositoryTest
	{

		private TrophyRepository.TrophyRepository _repository = new();

		[TestInitialize]
		public void Initialize()
		{

			_repository.Add(new Trophy() { Competition = "Abu Dhabi Grand Prix", Year = 1970});
			_repository.Add(new Trophy() { Competition = "Australian Open", Year = 2024});
			_repository.Add(new Trophy() { Competition = "Super Bowl", Year = 2019});
			_repository.Add(new Trophy() { Competition = "World cup", Year = 1999});
			_repository.Add(new Trophy() { Competition = "Basketball World Cup", Year = 2003});

		}

		[TestMethod]
		public void GetByIdTest()
		{

			Trophy trophy1 = _repository.GetById(1);
			Trophy trophy2 = _repository.GetById(2);

			Assert.IsNotNull(trophy1);
			Assert.AreEqual("Abu Dhabi Grand Prix", trophy1.Competition);

			Assert.IsNotNull(trophy2 );
			Assert.AreEqual("Australian Open", trophy2.Competition);

		}

		[TestMethod]
		public void GetTest()
		{

			IEnumerable<Trophy> trophies = _repository.Get();

			Assert.IsNotNull(trophies);

			List<Trophy> trophiesList = new List<Trophy>(trophies);

			Assert.AreEqual(10, trophiesList.Count);

		}

		[TestMethod]
		public void RemoveTest()
		{

		Trophy removedTrophy = _repository.Remove(1);
		IEnumerable<Trophy> trophies = _repository.Get();
		List<Trophy> trophiesList = new List<Trophy>(trophies);

		Assert.IsNotNull (removedTrophy);
		Assert.AreEqual(9, trophiesList.Count);
		Assert.IsNull (_repository.GetById(1));

		}

		[TestMethod]
		public void UpdateTest()
		{

			Trophy updatedTrophy = new Trophy { Competition = "competition updated", Year = 2017 };
			Trophy result = _repository.Update(1, updatedTrophy);
			Assert.IsNotNull (result);
			Assert.AreEqual("competition updated", result.Competition);
			Assert.AreEqual(1970, result.Year);

		}
	}
}
