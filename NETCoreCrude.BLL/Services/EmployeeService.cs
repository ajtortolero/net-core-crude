using NETCoreCrude.DAL.Models;
using NETCoreCrude.DAL.Repositories;
using System.Collections.Generic;

namespace FleetControl.BLL.Services
{
    /// <summary>
    ///
    /// </summary>
    public class EmployeeService
    {
        #region Properties

        /// <summary>
        ///
        /// </summary>
        private IEmployeeRepository _IEmployeeRepository;

        #endregion Properties

        #region Constructor

        /// <summary>
        ///
        /// </summary>
        /// <param name="_IEmployeeRepository"></param>
        public EmployeeService(IEmployeeRepository pIEmployeeRepository)
        {
            _IEmployeeRepository = pIEmployeeRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetList()
        {
            return _IEmployeeRepository.GetList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Employee GetByCode(string pCode)
        {
            return _IEmployeeRepository.GetByCode(pCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Employee Create(Employee pEmployee)
        {
            return _IEmployeeRepository.Create(pEmployee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Employee Update(Employee pEmployee)
        {
            return _IEmployeeRepository.Update(pEmployee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Employee Delete()
        {
            return _IEmployeeRepository.Delete();
        }

        #endregion Constructor
    }
}