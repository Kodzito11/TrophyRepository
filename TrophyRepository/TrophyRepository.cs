using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TrophyRepository;

namespace TrophyRepository
{
	public class TrophyRepository
	{
		private int _nextid = 1;
		private readonly List<Trophy> _trophies = new List<Trophy>();

		public TrophyRepository()
		{
			_trophies.Add(new Trophy() { Competition = "Abu Dhabi Grand Prix", Year = 1970, Id = _nextid++});
			_trophies.Add(new Trophy() { Competition = "Australian Open", Year = 2024, Id = _nextid++ });
			_trophies.Add(new Trophy() { Competition = "Super Bowl", Year = 2019, Id = _nextid++ });
			_trophies.Add(new Trophy() { Competition = "World cup", Year = 1999, Id = _nextid++ });
			_trophies.Add(new Trophy() { Competition = "Basketball World Cup", Year = 2003, Id = _nextid++ });
		}
		
		public List<Trophy> Get(int? Year = null, string? sortby = null)
		{
			if (Year == null)
			{

			}
			return new List<Trophy>(_trophies);
		}

		public Trophy? GetById(int id)
		{
			if (id == 0) return null;

			return _trophies.Find(t => t.Id == id);
		
		}

		public Trophy Add(Trophy trophy) 
		{
		
		trophy.Id = _nextid++;
			_trophies.Add(trophy);
			return trophy;
		
		}

		public Trophy? Remove(int id) 
		{

		Trophy? trophy = GetById(id);
		if (trophy == null) return null;
		_trophies.Remove(trophy);
		return trophy;
		
		}

		public Trophy? Update(int id, Trophy trophy) 
		{
			Trophy? existingtrophy = GetById(id);
			if (existingtrophy == null)
			{
				return null;
			}
			existingtrophy.Id = trophy.Year;
			existingtrophy.Competition = trophy.Competition;
			return existingtrophy;
		
		}

	}
}
