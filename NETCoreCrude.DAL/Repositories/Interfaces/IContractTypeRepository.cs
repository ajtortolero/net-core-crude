using System.Collections.Generic;
using NETCoreCrude.DAL.Models;

namespace NETCoreCrude.DAL.Repositories
{
    public interface IContractTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ContractType> GetList();
    }
}