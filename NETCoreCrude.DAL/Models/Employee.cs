using Newtonsoft.Json;

namespace NETCoreCrude.DAL.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Employee
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("EmployeeID")]
        public int EmployeeID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("Code")]
        public string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("Email")]
        public string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("ContractTypeID")]
        public int ContractTypeID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("SalaryBase")]
        public decimal SalaryBase { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("SalaryAmount")]
        public decimal SalaryAmount { get; set; }
    }
}