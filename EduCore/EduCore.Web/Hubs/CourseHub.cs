using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace EduCore.Web
{
    public class CourseHub : Hub
    {
        //private readonly PE_PRN_Fall22B1Context _context;
        //public CourseHub(PE_PRN_Fall22B1Context context)
        //{
        //    _context = context;
        //}
        //public async Task DeleteMovie(int? deleteId)
        //{
        //    if (deleteId != null)
        //    {
        //        var movie = _context.Movies
        //             .Include(x => x.Stars)
        //             .Include(x => x.Genres)
        //             .FirstOrDefault(x => x.Id == deleteId);
        //        movie.Stars.Clear();
        //        movie.Genres.Clear();
        //        _context.Movies.Remove(movie);
        //        _context.SaveChanges();
        //    }
        //    await Clients.All.SendAsync("LoadMovie", deleteId);
        //}
    }
}
