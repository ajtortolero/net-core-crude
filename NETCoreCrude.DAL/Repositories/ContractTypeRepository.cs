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
    public class ContractTypeRepository
        : IContractTypeRepository
    {
        /// <summary>
        ///
        /// </summary>
        private readonly IOptions<Base.Settting.AppConnectionStrings> _ConnectionString;

        /// <summary>
        ///
        /// </summary>
        /// <param name="pConnectionStrings"></param>
        public ContractTypeRepository(IOptions<Base.Settting.AppConnectionStrings> pConnectionStrings)
        {
            _ConnectionString = pConnectionStrings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ContractType> GetList()
        {
            var varResult = new List<ContractType>();
            using (SqlConnection varSqlConnection = new SqlConnection(_ConnectionString.Value.DefaultConnection))
            {
                try
                {
                    varSqlConnection.Open();
                    SqlCommand varSqlCommand = new SqlCommand("dbo.zSp_GetListContractType", varSqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    using (SqlDataReader varSqlDataReader = varSqlCommand.ExecuteReader())
                    {
                        while (varSqlDataReader.Read())
                        {
                            varResult.Add(new ContractType()
                            {
                                ContractTypeID = varSqlDataReader.GetInt32(0),
                                Name = varSqlDataReader.GetString(1)
                            });
                        }
                        return varResult;
                    }
                }
                catch (Exception varException)
                {
                    throw new AppFailure<ContractTypeRepository>("Failure in IEnumerable<ContractType> GetList() Exception: " + varException.Message);
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