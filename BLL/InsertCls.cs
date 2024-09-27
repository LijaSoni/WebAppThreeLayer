using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class InsertCls
    {
        ConnectionCls objdal = new ConnectionCls();
        public int DBInsert(string na, int ag, string addr, string ph, string una, string pwd)
        {
            string ins = "insert into Reg values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pwd + "')";
            int i = objdal.Fun_exenonquery(ins);
            return i;
        }
    }
}
