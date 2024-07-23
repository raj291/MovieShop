using MovieShop.Core.Models.Request;
using MovieShop.Core.Models.Response;

namespace MovieShop.Core.Interfaces.Services;

public interface IMovieServices
{
     int AddMovie(MovieRequestModel model);
    int UpdateMovie(MovieRequestModel model, int id);
    Task<IEnumerable<MovieResponseModel>> GetAllMovies();
    Task<MovieResponseModel> GetMovie(int id);
}