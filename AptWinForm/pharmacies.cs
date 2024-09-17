using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptWinForm
{
    [Serializable]
    public class Pharmacies
    {
        public List<Pharmacy> PharmacyList { get; set; } = new List<Pharmacy>();
        
        public Pharmacies() { }
    }
    [Serializable]
    public class Pharmacy
    {
        public string PhName { get; set; }
        public string StrverName {  get; set; }
        public string IP {  get; set; }
        public Pharmacy() { }

        public Pharmacy(string PhName, string StrverName, string IP) 
        {
            this.PhName = PhName;
            this.StrverName = StrverName;
            this.IP = IP;

        }
    }


}
