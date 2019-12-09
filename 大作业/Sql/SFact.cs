using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业
{
    class SFact
    {
        public SOperate Select( )
        {
            return new Select();
        }
        public SOperate Update()
        {
            return new Update();
        }
        public SOperate Delete()
        {
            return new Delete();
        }
        public SOperate Add()
        {
            return new Add();
        }
    }
}
