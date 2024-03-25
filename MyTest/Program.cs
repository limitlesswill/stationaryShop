namespace MyTest
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //// Create an instance of your form
            //StationeryContext _stationeryContext=new StationeryContext();
            //CategoryRepository categoryRepository = new CategoryRepository(_stationeryContext);
            //CategoryServices categoryServices = new CategoryServices(categoryRepository);
            //CategoryCRUD mainForm = new CategoryCRUD(categoryServices);

            //// Run your form using Application.Run()
            //Application.Run(mainForm);
        }
    }
}