using SATOLib.Database.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Container_and_Casemark.Class
{
    class DbReport
    {
        #region Variable 
        #endregion


        #region Property 

        public string ConnectionString { get; set; }
        private SqlDbms dbms { get; set; } = new SqlDbms();

        #endregion


        #region  Function

        public DataSet GetContainerReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                string storedProcedureName = "SP_CONTAINER_REPORT_GET";
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (this.ConnectionString.Length == 0)
                {
                    throw new NullReferenceException("Connection string is required.");
                }

                parameters.Add(new SqlParameter("@StartDate", startDate));
                parameters.Add(new SqlParameter("@EndDate", endDate));

                dbms.ConnectionString = this.ConnectionString;
                return dbms.GetStoredDataSet(storedProcedureName, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetCasemarkReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                string storedProcedureName = "SP_CASEMARK_REPORT_GET";
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (this.ConnectionString.Length == 0)
                {
                    throw new NullReferenceException("Connection string is required.");
                }

                parameters.Add(new SqlParameter("@StartDate", startDate));
                parameters.Add(new SqlParameter("@EndDate", endDate));

                dbms.ConnectionString = this.ConnectionString;
                return dbms.GetStoredDataSet(storedProcedureName, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetDateTimeServer()
        {
            try
            {
                string storedProcedureName = "SP_DATETIME_GET";
                if (this.ConnectionString.Length == 0)
                {
                    throw new NullReferenceException("Connection string is required.");
                }


                dbms.ConnectionString = this.ConnectionString;
                return dbms.GetStoredDataSet(storedProcedureName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        public DbReport()
        {

        }

        public DbReport(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

    }
}
