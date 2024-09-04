namespace ClearmechanicApi.Models.DTOs
{
	public class MovieResponseDTO
	{
        public List<MovieDTO>? Movies { get; set; }

        public int total { get; set; }

        public MovieResponseDTO(List<MovieDTO> movies, int total)
        {
            this.Movies = movies;
            this.total = total;
        }
    }
}

