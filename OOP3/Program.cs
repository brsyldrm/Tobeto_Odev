namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager financeCreditManager = new FinanceCreditManager();
            ICreditManager carLoanManager = new CarLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService,fileLoggerService};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(financeCreditManager,loggers);

            List<ICreditManager> krediler = new List<ICreditManager>() {financeCreditManager, carLoanManager };
            applicationManager.KrediOnBilgilendirme(krediler);
        }
    }
}