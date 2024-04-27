using AnthonyPWatts.Movies.Shared.Contracts.DTOs;

namespace AnthonyPWatts.Movies.Shared.Contracts.Interfaces;

public interface IMovieRepository
{
    public Task<IEnumerable<MovieDto>> GetAllAsync();
    public Task<MovieDto?> GetByIdAsync(Guid id);
    public Task<MovieDto?> AddAsync(MovieDto movie);
    public Task<MovieDto?> UpdateAsync(MovieDto movie);
    public Task<bool> DeleteAsync(Guid id);
}
