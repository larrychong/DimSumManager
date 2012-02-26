using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMPortTerminal
{
    class RequestList
    {
        List <String> reqList = new List <String>();
        public RequestList(List <String> list)
        {
            foreach (String s in list)
            {
                int table = int.Parse(s.Substring(0, s.IndexOf(':')));
                String reqType = s.Substring(s.IndexOf(':') + 1);
                String req = "Wrong";
                switch(reqType)
                {
                    case("T"): req = "Tea"; break;
                    case("C"): req = "to Checkout"; break;
                    case("S"): req = "Service"; break;

                }
                reqList.Add("Table " + table +  " wants " + req);
            }
        }

        public List<String> toStringList()
        {
            return reqList;
        }
    }
}
