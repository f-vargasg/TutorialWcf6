using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialWcf6.BE;

namespace TutorialWcf6.DL
{
    public class EmployeeDL : DataWorker
    {

        public Employee GetEmployee(int id)
        {
            Employee res = null;
            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand("SELECT * FROM TBLEMPLOYEE", connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["NAME"]);
                            if ((EmployeeType)reader["EMPLOYEETYPE"] == EmployeeType.FullTimeEmployee)
                            {
                                res = new FullTimeEmployee()
                                {
                                    Id = Convert.ToInt32(reader["ID"]),
                                    Name = Convert.ToString(reader["NAME"]),
                                    Gender = Convert.ToString(reader["GENDER"]),
                                    DateOfBirth = Convert.ToDateTime(reader["DATEOFBIRTH"]),
                                    Type = EmployeeType.FullTimeEmployee,
                                    AnnualSalary = Convert.ToInt32(reader["ANNUALSALARY"])
                                };
                            }
                            else
                            {
                                res = new PartTimeEmployee()
                                {
                                    Id = Convert.ToInt32(reader["ID"]),
                                    Name = Convert.ToString(reader["NAME"]),
                                    Gender = Convert.ToString(reader["GENDER"]),
                                    DateOfBirth = Convert.ToDateTime(reader["DATEOFBIRTH"]),
                                    Type = EmployeeType.PartTimeEmployee,
                                    HourlyPay = Convert.ToInt32(reader["HOURLYPAY"]),
                                    HoursWorked = Convert.ToInt32(reader["HOURSWORKED"])
                                };
                            }
                        }
                    }
                }
            }
            return res;
        }

        public void SaveEmployee(Employee pParams)
        {
            try
            {
                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateStoredProcCommand("pck_TBLEMPLOYEE.Inserta", connection))
                    {
                        #region Parameters
                        DbParameter param = database.CreateParameter("pid", DbType.Decimal, null);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pname", DbType.String, pParams.Name);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pgender", DbType.String, pParams.Gender);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pdateOfBirth", DbType.DateTime, pParams.DateOfBirth);
                        command.Parameters.Add(param);
                        param = database.CreateParameter("pemployeeType", DbType.Int32, pParams.Type);
                        command.Parameters.Add(param);
                        if (pParams.GetType() == typeof(FullTimeEmployee))
                        {
                            param = database.CreateParameter("pannualSalary", DbType.Int32,((FullTimeEmployee) pParams).AnnualSalary);
                            command.Parameters.Add(param);
                        }
                        else
                        {
                            param = database.CreateParameter("pannualSalary", DbType.Int32, null);
                            command.Parameters.Add(param);
                            param = database.CreateParameter("phourlyPay,", DbType.Int32, ((PartTimeEmployee)pParams).HourlyPay);
                            command.Parameters.Add(param);
                            param = database.CreateParameter("phoursWorked", DbType.Int32, ((PartTimeEmployee)pParams).HoursWorked);
                            command.Parameters.Add(param);
                        }
                        #endregion
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
