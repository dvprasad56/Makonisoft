using FAL;

namespace BAL
{
    public class EmployeeBAL
    {
        public bool SaveEmployeeData(string firstName, string lastName)
        {
            EmployeeDAL employee = new EmployeeDAL();
            bool result = employee.SaveEmployeeData(firstName, lastName);
            if(result)  
                return true;
            return false;
        }
    }
}