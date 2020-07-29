using NETCoreCrude.DAL.Models;
using NETCoreCrude.DAL.Repositories;
using System.Collections.Generic;

namespace FleetControl.BLL.Services
{
    /// <summary>
    ///
    /// </summary>
    public class ContractTypeService
    {
        #region Properties

        /// <summary>
        ///
        /// </summary>
        private IContractTypeRepository _IContractTypeRepository;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIContractTypeRepository"></param>
        public ContractTypeService(IContractTypeRepository pIContractTypeRepository)
        {
            _IContractTypeRepository = pIContractTypeRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ContractType> GetList()
        {
            return _IContractTypeRepository.GetList();
        }

        #endregion Constructor
    }
}