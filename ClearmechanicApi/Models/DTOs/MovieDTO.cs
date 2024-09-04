namespace ClearmechanicApi.Models.DTOs
{
	public class MovieDTO
	{
        public int Id { get; set; }

        public required string Title { get; set; }

        public int GenderId { get; set; }

        public required Gender Gender { get; set; }

        public int Year { get; set; }

        public String? Actors { get; set; }
    }
}

