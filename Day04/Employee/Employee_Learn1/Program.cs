namespace Employee_Learn1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Employee e = new Employee("Bob", "Jones", 2, 2, 1989, 3, 12, 2016);

            MessageBox.Show(e.ToEmployeeString(), "Testing Class Employee");
        }
    }
}