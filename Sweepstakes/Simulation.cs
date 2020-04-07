using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = UserInterface.GetManagerType();            
            MarketingFirm marketingFirm = new MarketingFirm(manager);
            marketingFirm.CreateSweepstake();
        }
    }
}
