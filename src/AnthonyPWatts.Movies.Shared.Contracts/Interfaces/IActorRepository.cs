using AnthonyPWatts.Movies.Shared.Contracts.DTOs;

namespace AnthonyPWatts.Movies.Shared.Contracts.Interfaces;

public interface IActorRepository
{
    public Task<IEnumerable<ActorDto>> GetAllAsync();
    public Task<ActorDto?> GetByIdAsync(Guid id);
    public Task<ActorDto?> AddAsync(ActorDto actor);
    public Task<ActorDto?> UpdateAsync(ActorDto actor);
    public Task<bool> DeleteAsync(Guid id);
}
