using System.Runtime.Serialization;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    public async Task<Artist> CreateArtist(Artist artist)
    {
        // throw new NotImplementedException();
        return new Artist(){
            Id = 1,
            Name = "Master",
            Label = "EMI",
            IsOnTour = true
        };
    }

    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        // throw new NotImplementedException();
        var list = new List<Artist>();
        list.Add(new Artist(){
            Id = 1,
            Name = "Master",
            Label = "EMI",
            IsOnTour = true
        });
        return list;
    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}