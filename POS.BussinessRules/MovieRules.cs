using Microsoft.Data.SqlClient;
using POS.DataAccess;
using POS.Model;
using System.Data;

namespace POS.BUSSINESSRULES
{
    public class MovieRules
    {
        private SqlServerData obj = new SqlServerData();
        private MovieDetails md = new MovieDetails();
        
        public MovieRules() { }

        public bool AddMovie(MovieDetails movie)
        {
            if(obj.CreateTicket(movie) >= 1)
            {
                return true;
            }
            else return false;
        }      

        public DataTable GetMovieList()
        {
            DataTable dt = new DataTable();
            dt = obj.fetchTable();
            return dt;
        }
        public bool UpdateMovie(MovieDetails movie)
        {
            return obj.UpdateDetails(movie);
        }
        public bool DeleteMovie(int id) {
            return obj.DeleteDetails(id);
        }
        
    }
}