using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager,List<ILoggerService> loggerService)
        {
            creditManager.Calculate();
            foreach (var item in loggerService)
            {
                item.Log();
            }
        }
        public void KrediOnBilgilendirme(List<ICreditManager> krediler)
        {
            foreach (var credit in krediler)
            {
                credit.Calculate();
            }
        }
    }
}
