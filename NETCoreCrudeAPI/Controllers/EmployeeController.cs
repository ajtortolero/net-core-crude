using FleetControl.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using NETCoreCrude.DAL.Models;
using NETCoreCrude.DAL.Repositories;
using System;

namespace NETCoreCrudeAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController
        : Controller
    {
        #region Properties

        /// <summary>
        ///
        /// </summary>
        private EmployeeService _EmployeeService;

        #endregion Properties

        #region Constructor

        /// <summary>
        ///
        /// </summary>
        /// <param name="pIEmployeeRepository"></param>
        public EmployeeController(IEmployeeRepository pIEmployeeRepository)
        {
            _EmployeeService = new EmployeeService(pIEmployeeRepository);
        }

        #endregion Constructor

        #region Operations

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Employees/GetList")]
        public IActionResult GetList()
        {
            var varResult = _EmployeeService.GetList();
            return new OkObjectResult(varResult);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Employees/GetByCode/{pCode}")]
        public IActionResult GetByCode(string pCode)
        {
            var varResult = _EmployeeService.GetByCode(pCode);
            return new OkObjectResult(varResult);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pEmployee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Employees")]
        public IActionResult CreateEmployee([FromBody]Employee pEmployee)
        {
            try
            {
                var varResult = _EmployeeService.Create(pEmployee);
                return new OkObjectResult(varResult);
            }
            catch (Exception varException)
            {
                return new BadRequestObjectResult(varException.Message);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pEmployee"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Employees/{pID}")]
        public IActionResult UpdateEmployee([FromBody]Employee pEmployee)
        {
            try
            {
                var varResult = _EmployeeService.Update(pEmployee);
                return new OkObjectResult(varResult);
            }
            catch (Exception varException)
            {
                return new BadRequestObjectResult(varException.Message);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pEmployee"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Employees/{pID}")]
        public IActionResult DeleteEmployee([FromBody]Employee pEmployee)
        {
            try
            {
                return new OkObjectResult(pEmployee);
            }
            catch (Exception varException)
            {
                return new BadRequestObjectResult(varException.Message);
            }
        }

        #endregion Operations
    }
}