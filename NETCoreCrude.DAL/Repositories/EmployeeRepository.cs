using Microsoft.Extensions.Options;
using NETCoreCrude.Base;
using NETCoreCrude.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NETCoreCrude.DAL.Repositories
{
    /// <summary>
    ///
    /// </summary>
    public class EmployeeRepository
        : IEmployeeRepository
    {
        /// <summary>
        ///
        /// </summary>
        private readonly IOptions<Base.Settting.AppConnectionStrings> _ConnectionString;

        /// <summary>
        ///
        /// </summary>
        /// <param name="pConnectionStrings"></param>
        public EmployeeRepository(IOptions<Base.Settting.AppConnectionStrings> pConnectionStrings)
        {
            _ConnectionString = pConnectionStrings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetList()
        {
            var varResult = new List<Employee>();
            using (SqlConnection varSqlConnection = new SqlConnection(_ConnectionString.Value.DefaultConnection))
            {
                try
                {
                    varSqlConnection.Open();
                    SqlCommand varSqlCommand = new SqlCommand("dbo.zSp_GetListEmployee", varSqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader varSqlDataReader = varSqlCommand.ExecuteReader())
                    {
                        while (varSqlDataReader.Read())
                        {
                            varResult.Add(new Employee()
                            {
                                EmployeeID = varSqlDataReader.GetInt32(0),
                                Code = varSqlDataReader.GetString(1),
                                Name = varSqlDataReader.GetString(2),
                                LastName = varSqlDataReader.GetString(3),
                                Mobile = varSqlDataReader.GetString(4),
                                Email = varSqlDataReader.GetString(5),
                                ContractTypeID = varSqlDataReader.GetInt32(6),
                                SalaryBase = varSqlDataReader.GetDecimal(7),
                                SalaryAmount = varSqlDataReader.GetDecimal(8)
                            });
                        }
                        return varResult;
                    }
                }
                catch (Exception varException)
                {
                    throw new AppFailure<ContractTypeRepository>("Failure in IEnumerable<Employee> GetList() Exception: " + varException.Message);
                }
                finally
                {
                    varSqlConnection.Close();
                    varSqlConnection.Dispose();
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public Employee GetByCode(string pCode)
        {
            var varResult = new Employee();
            using (SqlConnection varSqlConnection = new SqlConnection(_ConnectionString.Value.DefaultConnection))
            {
                try
                {
                    varSqlConnection.Open();
                    SqlCommand varSqlCommand = new SqlCommand("dbo.zSp_GetListEmployee", varSqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader varSqlDataReader = varSqlCommand.ExecuteReader())
                    {
                        while (varSqlDataReader.Read())
                        {
                            varResult = new Employee()
                            {
                                EmployeeID = varSqlDataReader.GetInt32(0),
                                Code = varSqlDataReader.GetString(1),
                                Name = varSqlDataReader.GetString(2),
                                LastName = varSqlDataReader.GetString(3),
                                Mobile = varSqlDataReader.GetString(4),
                                Email = varSqlDataReader.GetString(5),
                                ContractTypeID = varSqlDataReader.GetInt32(6),
                                SalaryBase = varSqlDataReader.GetDecimal(7),
                                SalaryAmount = varSqlDataReader.GetDecimal(8)
                            };
                        }
                        return varResult;
                    }
                }
                catch (Exception varException)
                {
                    throw new AppFailure<ContractTypeRepository>("Failure in IEnumerable<Employee> GetList() Exception: " + varException.Message);
                }
                finally
                {
                    varSqlConnection.Close();
                    varSqlConnection.Dispose();
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public Employee Create(Employee pEmployee)
        {
            var varResult = new Employee();
            using (SqlConnection varSqlConnection = new SqlConnection(_ConnectionString.Value.DefaultConnection))
            {
                try
                {
                    varSqlConnection.Open();
                    SqlCommand varSqlCommand = new SqlCommand("dbo.zSp_CreateEmployee", varSqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader varSqlDataReader = varSqlCommand.ExecuteReader())
                    {
                        while (varSqlDataReader.Read())
                        {
                            varResult.EmployeeID = varSqlDataReader.GetInt32(0);
                            varResult.Code = varSqlDataReader.GetString(1);
                            varResult.Name = varSqlDataReader.GetString(2);
                            varResult.LastName = varSqlDataReader.GetString(3);
                            varResult.Mobile = varSqlDataReader.GetString(4);
                            varResult.Email = varSqlDataReader.GetString(5);
                            varResult.ContractTypeID = varSqlDataReader.GetInt32(6);
                            varResult.SalaryBase = varSqlDataReader.GetDecimal(7);
                            varResult.SalaryAmount = varSqlDataReader.GetDecimal(8);
                        }
                        return varResult;
                    }
                }
                catch (Exception varException)
                {
                    throw new AppFailure<ContractTypeRepository>("Failure in Employee Create() Exception: " + varException.Message);
                }
                finally
                {
                    varSqlConnection.Close();
                    varSqlConnection.Dispose();
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public Employee Update(Employee pEmployee)
        {
            var varResult = new Employee();
            using (SqlConnection varSqlConnection = new SqlConnection(_ConnectionString.Value.DefaultConnection))
            {
                try
                {
                    varSqlConnection.Open();
                    SqlCommand varSqlCommand = new SqlCommand("dbo.zSp_CreateEmployee", varSqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader varSqlDataReader = varSqlCommand.ExecuteReader())
                    {
                        while (varSqlDataReader.Read())
                        {
                            varResult.EmployeeID = varSqlDataReader.GetInt32(0);
                            varResult.Code = varSqlDataReader.GetString(1);
                            varResult.Name = varSqlDataReader.GetString(2);
                            varResult.LastName = varSqlDataReader.GetString(3);
                            varResult.Mobile = varSqlDataReader.GetString(4);
                            varResult.Email = varSqlDataReader.GetString(5);
                            varResult.ContractTypeID = varSqlDataReader.GetInt32(6);
                            varResult.SalaryBase = varSqlDataReader.GetDecimal(7);
                            varResult.SalaryAmount = varSqlDataReader.GetDecimal(8);
                        }
                        return varResult;
                    }
                }
                catch (Exception varException)
                {
                    throw new AppFailure<ContractTypeRepository>("Failure in Employee Create() Exception: " + varException.Message);
                }
                finally
                {
                    varSqlConnection.Close();
                    varSqlConnection.Dispose();
                }
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public Employee Delete()
        {
            var varResult = new Employee();
            using (SqlConnection varSqlConnection = new SqlConnection(_ConnectionString.Value.DefaultConnection))
            {
                try
                {
                    varSqlConnection.Open();
                    SqlCommand varSqlCommand = new SqlCommand("dbo.zSp_CreateEmployee", varSqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader varSqlDataReader = varSqlCommand.ExecuteReader())
                    {
                        while (varSqlDataReader.Read())
                        {
                            varResult.EmployeeID = varSqlDataReader.GetInt32(0);
                            varResult.Code = varSqlDataReader.GetString(1);
                            varResult.Name = varSqlDataReader.GetString(2);
                            varResult.LastName = varSqlDataReader.GetString(3);
                            varResult.Mobile = varSqlDataReader.GetString(4);
                            varResult.Email = varSqlDataReader.GetString(5);
                            varResult.ContractTypeID = varSqlDataReader.GetInt32(6);
                            varResult.SalaryBase = varSqlDataReader.GetDecimal(7);
                            varResult.SalaryAmount = varSqlDataReader.GetDecimal(8);
                        }
                        return varResult;
                    }
                }
                catch (Exception varException)
                {
                    throw new AppFailure<ContractTypeRepository>("Failure in Employee Create() Exception: " + varException.Message);
                }
                finally
                {
                    varSqlConnection.Close();
                    varSqlConnection.Dispose();
                }
            }
        }
    }
}