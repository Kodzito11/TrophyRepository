namespace TrophyRepository
{
	public class Trophy
	{

		public int Id { get; set; }

		public string Competition { get; set; }

		public int Year { get; set; }

		public override string ToString()
		{
			return $"Id: {Id}, Competition: {Competition}, Year: {Year}";

		}

		public void ValidateCompetition()
		{
			if (Competition == null)
			{

				throw new ArgumentNullException("Competition cant be null");

			}
			if (Competition.Length <= 3)
			{

				throw new ArgumentOutOfRangeException("This must be atleast 3 characters");

			}

		}

		public void ValidateYear() 
		{
		
			if (Year < 1970 || Year > 2024 ) 
			{
			
			 throw new ArgumentOutOfRangeException("The Year must be between 1970-2024");
			
			}
		
		}

		public void Validate()
		{

			ValidateCompetition();

			ValidateYear();

		}
	}
}
