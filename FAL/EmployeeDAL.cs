namespace FAL
{
    public class EmployeeDAL
    {
        public bool SaveEmployeeData(string firstName, string lastName)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            { 
                w.WriteLine("First Name : " + firstName + "\n");
                w.WriteLine("Last Name : " + lastName);
            }
            return true;
        }
    }
}