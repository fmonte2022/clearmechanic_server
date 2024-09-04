using AutoMapper;
using ClearmechanicApi.Models;
using ClearmechanicApi.Models.DTOs;

namespace ClearmechanicApi
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Movie, MovieDTO>().ForMember(
				m => m.Actors, o => o.MapFrom(s => string.Join(", ", s.MovieActors!.Select(a => a.Actor!.Name)))
			);
        }
    }
}

