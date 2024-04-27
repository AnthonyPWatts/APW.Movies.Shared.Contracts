using AnthonyPWatts.Movies.Shared.Contracts.DTOs;

namespace AnthonyPWatts.Movies.Shared.Contracts.Interfaces;

public interface IMovieActorRepository
{
    public Task<IEnumerable<MovieActorDto>> GetAllAsync();
    public Task<IEnumerable<MovieActorDto>> GetAllByMovieIdAsync(Guid id);
    public Task<IEnumerable<MovieActorDto>> GetAllByActorIdAsync(Guid id);
    public Task<MovieActorDto?> AddAsync(MovieActorDto movieActor);
    public Task<bool> DeleteAsync(Guid movieId, Guid actorId);
    
}
