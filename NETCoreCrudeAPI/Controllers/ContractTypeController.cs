using FleetControl.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using NETCoreCrude.DAL.Repositories;

namespace NETCoreCrudeAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/ContractType")]
    public class ContractTypeController
        : Controller
    {
        #region Properties

        /// <summary>
        ///
        /// </summary>
        private ContractTypeService _ContractTypeService;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIContractTypeRepository"></param>
        public ContractTypeController(IContractTypeRepository pIContractTypeRepository)
        {
            _ContractTypeService = new ContractTypeService(pIContractTypeRepository);
        }

        #endregion Constructor

        #region Operations

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ContractTypes/GetList")]
        public IActionResult GetList()
        {
            var varResult = _ContractTypeService.GetList();
            return new OkObjectResult(varResult);
        }

        #endregion Operations
    }
}