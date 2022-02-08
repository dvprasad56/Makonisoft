using System.Text.Json;

namespace FAL
{
    public class EmployeeDAL
    {
        public bool SaveEmployeeData(string firstName, string lastName)
        {
            var filePath = Directory.GetCurrentDirectory() + "\\log.json";
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName
            };
            string json = JsonSerializer.Serialize(employee);
            File.WriteAllText(filePath, json);
            return true;
        }
    }
}