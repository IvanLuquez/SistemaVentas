using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerData
{

    public class AccesDB
    {
        private string dataBase;
        private string server;
        private string port;
        private string username;
        private string password;
        private static AccesDB conexion = null;

        public AccesDB()
        {
            this.dataBase = "salesup";
            this.server =  "localhost";
            this.port =  "5432";
            this.username = "postgres";
            this.password = "admin";
        }

        public NpgsqlConnection createConection() {
        
            NpgsqlConnection conn = new NpgsqlConnection();

            try
            {
                conn.ConnectionString = "Server=" + this.server
                                         + ";Port=" + this.port
                                         + ";User id=" + this.username
                                         + ";Password=" + this.password
                                         + ";Database=" + this.dataBase;
            }
            catch (Exception ex)
            {
                conn = null;
                throw ex;
            }

            return conn;
        }

        public static AccesDB getInstance()
        {
            if (conexion == null)
            {
                conexion = new AccesDB();
            }

            return conexion;
        } 
    }
}
