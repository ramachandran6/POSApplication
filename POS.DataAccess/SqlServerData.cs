using Microsoft.Data.SqlClient;
using POS.Model;
using System.Data;

namespace POS.DataAccess
{
    public class SqlServerData
    {
        private string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"POS db\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

     

        public int CreateTicket(MovieDetails md)
        {
            SqlConnection conn=new SqlConnection(ConnectionString);

            conn.Open();

            string query = $"INSERT INTO MovieDetails (Name,Mail,MobileNumber,MovieName,NoOfSeats,TotalAmount) VALUES('{md.Name}','{md.Mail}','{md.MobileNumber}','{md.MovieName}','{md.NoOfSeats}','{md.Amount}')";

            SqlCommand command=new SqlCommand(query, conn);
            command.CommandText = query;
            command.Connection = conn;
            command.CommandType=System.Data.CommandType.Text;

            int resultsAffected=command.ExecuteNonQuery();

            if(conn.State== System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return resultsAffected;
        }

        public DataTable fetchTable()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            string query = $"Select id,Name,Mail,MobileNumber,MovieName,NoOfSeats,TotalAmount from MovieDetails";

            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dsresult = new DataSet("MovieDteails2");
            adapter.Fill(dsresult);
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

            return dsresult.Tables[0];

        }
        public bool UpdateDetails(MovieDetails movie)
        {
            //SQL CONNECTION AND OPEN
            SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"POS db\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            sqlConn.Open();

            //SQL UPDATE QUERY
            string query = $"UPDATE MovieDetails SET Name = '{movie.Name}' ,Mail = '{movie.Mail}',MobileNumber = '{movie.MobileNumber}',MovieName = '{movie.MovieName}',NoOfSeats = '{movie.NoOfSeats}',TotalAmount = {movie.Amount} where Id = {movie.Id} ";

            //SQL COMMAND
            SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            int rowsAffected = sqlCommand.ExecuteNonQuery();
            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                sqlConn.Close();
            }


            if (rowsAffected > 0)
            {
                return true;
            }
            else return false;


        }
        public bool DeleteDetails(int id)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"POS db\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            sqlConn.Open();

            string query = $"DELETE FROM MOVIEDETAILS where Id = {id}";

            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = query;
            sqlcom.CommandType = System.Data.CommandType.Text;
            sqlcom.Connection = sqlConn;
            int rowsAfffected = sqlcom.ExecuteNonQuery();
            if(rowsAfffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}