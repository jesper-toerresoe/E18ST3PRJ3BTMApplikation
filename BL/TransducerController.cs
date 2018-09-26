using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class TransducerController
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
