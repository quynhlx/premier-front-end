﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using log4net;

namespace debt_fe.DataAccessHelper
{
    public class DataProvider
    {
        private static readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private SqlConnection _connection;

        private string _username;
        private string _password;

        public DataProvider()
        {

        }

		/// <summary>
		/// create new instance of data provider with username and password
		/// </summary>
		/// <param name="username">username of connection string</param>
		/// <param name="password">password of connection string</param>
        public DataProvider(string username, string password)
        {
            this._username = username;
            this._password = password;
        }

        private void Connect()
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            connectionString = string.Format("{0}; User ID={1}; Password={2}", connectionString, _username, _password);

            if (_connection == null)
            {
				try
				{
					_connection = new SqlConnection(connectionString);
				}
				catch (Exception ex)
				{
					throw ex;
				}
            }


            // return (_connection.State == ConnectionState.Open);
        }

        /// <summary>
        /// Execute select command
        /// </summary>
        /// <param name="query">a string is select command</param>
        /// <returns>a DataTable of select query result</returns>
        public DataTable ExecuteQuery(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new Exception("Query not found");
            }

			try
			{
				Connect();
			}
            catch
            {
                throw new Exception("Cannot connect to database: " + _connection.ConnectionString);
            }

            var adapter = new SqlDataAdapter(query, _connection);
            var table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// execute a select query with parameter
        /// </summary>
        /// <param name="query">a string of select query</param>
        /// <param name="paramNames">a list string of parameter names</param>
        /// <param name="paramValues">an arraylist of parameter values</param>
        /// <returns>a datatable of query result</returns>
        public DataTable ExecuteQuery(string query, List<string> paramNames, ArrayList paramValues)
        {
            


            if (string.IsNullOrEmpty(query))
            {
                throw new Exception("Query not found");
            }

			try
			{
				Connect();
			}
            catch
            {
                throw new Exception("Cannot connect to database: " + _connection.ConnectionString);
            }


            var cmd = new SqlCommand(query, _connection);

            for (int i = 0; i < paramNames.Count; i++)
            {
                var name = paramNames[i].TrimStart('@');
                name = string.Format("@{0}",name);

                cmd.Parameters.AddWithValue(name, paramValues[i]);
            }

			

            try
            {
				var adapter = new SqlDataAdapter(cmd);
				var table = new DataTable();

                adapter.Fill(table);
				return table;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Execute query command: insert, update, delete
        /// </summary>
        /// <param name="query">a string of query command</param>
        public void ExecuteNonQuery(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new Exception("Query not found");
            }

            try
			{
				Connect();
			}
			catch
            {
                throw new Exception("Cannot connect to database: " + _connection.ConnectionString);
            }

            _connection.Open();
            var cmd = new SqlCommand(query, _connection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

        }

        /// <summary>
        /// Execute query command with parameters
        /// </summary>
        /// <param name="query">a string of query command</param>
        public void ExecuteNonQuery(string query, List<string> paramNames, ArrayList paramValues)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new Exception("Query not found");
            }

            try
			{
				Connect();
			}
			catch
            {
                throw new Exception("Cannot connect to database: " + _connection.ConnectionString);
            }

            _connection.Open();
            var cmd = new SqlCommand(query, _connection);            

            for (int i = 0; i < paramNames.Count; i++)
            {
                var name = paramNames[i].TrimStart('@');
                name = string.Format("@{0}", name);

                cmd.Parameters.AddWithValue(name, paramValues[i]);
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

        }

        /// <summary>
        /// Execute select store procedure
        /// </summary>
        /// <param name="storeProc">a string is store procedure name</param>
        /// <param name="paramNames">a string collection of parameters name without @</param>
        /// <param name="paramValues">an array list of parameters value</param>
        /// <returns>an object of store procedure result</returns>
        public object ExecuteStoreProcedure(string storeProc, List<string> paramNames, ArrayList paramValues)
        {
            object returnValue = null;

            if (string.IsNullOrEmpty(storeProc))
            {
                throw new Exception("Store procedure not found");
            }

            if (paramNames == null || paramNames.Count == 0)
            {
                throw new Exception("Parameters not found");
            }

            try
			{
				Connect();
			}
			catch
            {
                throw new Exception("Cannot connect to database: " + _connection.ConnectionString);
            }

            /*
             * prepare data
             * */
            var cmd = new SqlCommand(storeProc, _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < paramNames.Count; i++)
            {
                cmd.Parameters.AddWithValue(paramNames[i], paramValues[i]);
            }

            var returnParam = cmd.Parameters.Add("@b", SqlDbType.NVarChar);
            returnParam.Direction = ParameterDirection.ReturnValue;

            /*
             * execute query
             * */
            try
            {
                _connection.Open();
                cmd.ExecuteNonQuery();

                returnValue = cmd.Parameters["@b"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }


            return returnValue;
        }

        /// <summary>
        /// Execute select store procedure
        /// </summary>
        /// <param name="storeProc">a string is store procedure name</param>
        /// <param name="paramNames">a string collection of parameters name without @</param>
        /// <param name="paramValues">an array list of parameters value</param>
        /// <returns>a dataset of store procedure result</returns>
        public DataSet ExecuteStoreProcedure(string storeProc, List<string> paramNames, ArrayList paramValues, out int returnValue)
        {           
			returnValue = 0;

            if (string.IsNullOrEmpty(storeProc))
            {
                throw new Exception("Store procedure not found");
            }

            if (paramNames == null || paramNames.Count == 0)
            {
                throw new Exception("Parameters not found");
            }

            try
			{
				Connect();
			}
			catch
            {
                throw new Exception("Cannot connect to database: " + _connection.ConnectionString);
            }
            
			var cmd = new SqlCommand(storeProc, _connection);
            cmd.CommandType = CommandType.StoredProcedure;

			for (int i = 0; i < paramNames.Count; i++)
			{
				cmd.Parameters.AddWithValue(paramNames[i], paramValues[i]);
			}

			var returnParam = cmd.Parameters.Add("@b", SqlDbType.NVarChar);
			returnParam.Direction = ParameterDirection.ReturnValue;

			var ds = new DataSet();
            
            try
            {

				var adapter = new SqlDataAdapter(cmd);
				adapter.Fill(ds);                

                returnValue = (int)cmd.Parameters["@b"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }

				if (cmd != null)
				{
					cmd.Dispose();
				}
            }

            return ds;
        }
    }
}