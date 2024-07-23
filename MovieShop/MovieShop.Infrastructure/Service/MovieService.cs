using MovieShop.Core.Interfaces.Repository;
using MovieShop.Core.Interfaces.Services;
using MovieShop.Core.Models.Request;
using MovieShop.Core.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieShop.Core.Entities;

namespace MovieShop.Infrastructure.Service
{
    public class MovieService : IMovieServices
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public int AddMovie(MovieRequestModel model)
        {
            throw new NotImplementedException();
        }

        public int UpdateMovie(MovieRequestModel model, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MovieResponseModel>> GetAllMovies()
        {
            var result = await Task.Run(() => movieRepository.GetAll());
            var movieResponseModels = new List<MovieResponseModel>();

            foreach (var m in result)
            {
                var model = new MovieResponseModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Overview = m.Overview,
                    BackdropUrl = m.BackdropUrl,
                    PosterUrl = m.PosterUrl,
                    RunTime = m.RunTime,
                    Tagline = m.Tagline
                };
                movieResponseModels.Add(model);
            }

            return movieResponseModels;
        }

        public async Task<MovieResponseModel> GetMovie(int id)
        {
            var movie = await movieRepository.GetMovieByIdAsync(id);
            if (movie != null)
            {
                return new MovieResponseModel()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Overview = movie.Overview,
                    PosterUrl = movie.PosterUrl,
                    Revenue = movie.Revenue,
                    RunTime = movie.RunTime,
                    ImdbUrl = movie.ImdbUrl,
                    BackdropUrl = movie.BackdropUrl,
                    Tagline = movie.Tagline,
                    ReleaseDate = movie.ReleaseDate,
                    Budget = movie.Budget,
                    Casts = movie.MovieCastsList.Select(mc => new CastResponseModel
                    {
                        Id = mc.Casts.Id,
                        Name = mc.Casts.Name,
                        ProfilePath = mc.Casts.ProfilePath,
                        TmdbUrl = mc.Casts.TmdbUrl,
                        Character = mc.Character, 
                    }).ToList(),
                    // Genres = movie.MovieGenresList.Select(mg => new GenresResponseModel
                    // {
                    //     Id = mg.GenreId,
                    //     Name = mg.Genres.Name
                    // }).ToList(),
                    Trailers = movie.TrailersList.Select(t => new TrailerResponseModel
                    {
                       MovieId = t.MovieId,
                       TrailerUrl = t.TrailerUrl,
                       Name = t.Name,
                        
                    }).ToList()
                };
            }

            return null;
        }
    }
}