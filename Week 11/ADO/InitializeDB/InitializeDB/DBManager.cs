using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace InitializeDB
{
    public class DBManager
    {
        SqlConnection bitdevConnection;

        public void connect()
        {
            bitdevConnection = new SqlConnection();

            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_BATESSR1;" +
                                                "User ID = batessr1;" +
                                                "Password = XXXXX;";
            bitdevConnection.Open();
        }

        public void populate()
        {
            connect();

            createTutorsTable();
            createPapersTable();
            createAssignmentsTable();

            insertAllAssignments();
            //insertAllPapers();
            //insertAllTutors();

            bitdevConnection.Close();
        }

        private void insertAllAssignments()
        {
            String q = "INSERT INTO dbo.tblTutors VALUES ('Patricia', 'Haden', 'phaden@op.ac.nz', '555555555');";
            SqlCommand sqlcmd = new SqlCommand(q,bitdevConnection);
            sqlcmd.ExecuteNonQuery();
        }
        
        private void createTutorsTable()
        {
            String q = "CREATE TABLE db.tblTutors ( " +
                    "TutorID int NOT NULL AUTO_INCREMENT," +
                    "FirstName VARCHAR(50) NOT NULL," +
                    "LastName VARCHAR(50) NOT NULL," +
                    "Email VARCHAR(50)" +
                    "PRIMARY KEY (TutorID))";

            SqlCommand sqlcmd = new SqlCommand(q, bitdevConnection);
            sqlcmd.ExecuteNonQuery();
        }
        private void createPapersTable()
        {
            String q = "CREATE TABLE db.tblPapers ( " +
                "PaperID INT IDENTITY, " +
                "TutorID INT, " +
                "Name VARCHAR(50), " +
                "PRIMARY KEY (PaperID))";

            SqlCommand sqlcmd = new SqlCommand(q, bitdevConnection);
            sqlcmd.ExecuteNonQuery();
        }
        private void createAssignmentsTable()
        {
            String q = "CREATE TABLE db.tblAssignments (" +
                                        "AssignmentID INT IDENTITY, " +
                                        "PaperID INT, " +
                                        "Name VARCHAR(50)," +
                                        "DueDate DATE, " +
                                        "Grade INT, " +
                                        "PRIMARY KEY (AssignmentID))";
            SqlCommand sqlcmd = new SqlCommand(q, bitdevConnection);
            sqlcmd.ExecuteNonQuery();
        }
        
    }
}

