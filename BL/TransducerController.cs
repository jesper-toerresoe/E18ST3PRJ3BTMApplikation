using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Interface.BL;

namespace BL
{
    
    public class TransducerController : iTransducerCtrl
    {
        DALInit mydal;
        public void InitTransducer() {
            mydal = new DALInit();
            mydal.InitDal();
        }

        public void StartKalibaration() {

            var x = 3;
            mydal.LaesTryk();
        }

    }
}
