
using TalebElm.Application.DTOs;

namespace TalebElm.Application.Services
{
    public interface ITrackService
    {
        public Task<IReadOnlyList<TrackResponse>> GetAllAsync();
        public Task<TrackResponse> CreateAsync(CreateTrackRequest trackrequest);
    }
}
