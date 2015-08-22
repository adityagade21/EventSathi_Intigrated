using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PL;
using DL;
//testing
namespace BL
{
   public  class BAFAQ
    {
       DAFAQ objDA = new DAFAQ();
       public int AddFAQ(PAAdminFAQ  objPA)
       {
           return objDA.AddFAQ(objPA);
       }
       public int DeleteFAQ(PAAdminFAQ objPA)
       {
           return objDA.DeleteFAQ(objPA);
       }
    }
}
