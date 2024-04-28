using AnthonyPWatts.Movies.Shared.Contracts.DTOs;

namespace AnthonyPWatts.Movies.Shared.Contracts.Interfaces;

public interface IMovieActorRepository
{
    public Task<IEnumerable<MovieActorDto>> GetAllAsync();
    public Task<MovieActorDto?> GetByIdAsync(int movieId, int actorId);
    public Task<IEnumerable<MovieActorDto>> GetAllByMovieIdAsync(int id);
    public Task<IEnumerable<MovieActorDto>> GetAllByActorIdAsync(int id);
    public Task<MovieActorDto?> AddAsync(MovieActorDto movieActor);
    public Task<bool> DeleteAsync(int movieId, int actorId);
    
}
