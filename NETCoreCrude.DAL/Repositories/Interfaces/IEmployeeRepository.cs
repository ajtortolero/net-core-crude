using NETCoreCrude.DAL.Models;
using System.Collections.Generic;

namespace NETCoreCrude.DAL.Repositories
{
    public interface IEmployeeRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetList();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Employee GetByCode(string pCode);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Employee Create(Employee pEmployee);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Employee Update(Employee pEmployee);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Employee Delete();
    }
}