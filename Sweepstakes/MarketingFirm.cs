using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {     
        public ISweepstakesManager manager;  

        public MarketingFirm()
        {
            
        }
        public void CreateSweepstake()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.Name = UserInterface.GetSweepstakeName();
            manager = UserInterface.GetManagerType();
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
