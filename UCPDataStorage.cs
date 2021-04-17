using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint1
{
    public class UCPDataStorage
    {
        private decimal TCFtotal = 0;
        List<decimal> TCFValslist = new List<decimal>();
        private decimal TCFVal = (decimal)0.6;


        private decimal ECFtotal = 0;
        List<decimal> ECFValslist = new List<decimal>();
        private decimal ECFVal = (decimal)1.4;

        private decimal UUCWSval;
        private decimal UUCWAval;
        private decimal UUCWCval;
        private decimal UAWSval;
        private decimal UAWAval;
        private decimal UAWCval;

        private decimal UUCWTotalVal;
        private decimal UAWTotalVal;


        private decimal PFval = 20;
        private decimal LOCUCPval = 100;
        private decimal LOCPMval = 700;

        private decimal UCPVal;
        private decimal UUCPVal;
        private decimal estHrsVal;
        private decimal estLocVal;
        private decimal estPMVal;

        public decimal TCFtotal1 { get => TCFtotal; set => TCFtotal = value; }
        public List<decimal> TCFValslist1 { get => TCFValslist; set => TCFValslist = value; }
        public decimal ECFtotal1 { get => ECFtotal; set => ECFtotal = value; }
        public List<decimal> ECFValslist1 { get => ECFValslist; set => ECFValslist = value; }
        public decimal UUCWSval1 { get => UUCWSval; set => UUCWSval = value; }
        public decimal UUCWAval1 { get => UUCWAval; set => UUCWAval = value; }
        public decimal UUCWCval1 { get => UUCWCval; set => UUCWCval = value; }
        public decimal UAWSval1 { get => UAWSval; set => UAWSval = value; }
        public decimal UAWAval1 { get => UAWAval; set => UAWAval = value; }
        public decimal UAWCval1 { get => UAWCval; set => UAWCval = value; }
        public decimal PFval1 { get => PFval; set => PFval = value; }
        public decimal LOCUCPval1 { get => LOCUCPval; set => LOCUCPval = value; }
        public decimal LOCPMval1 { get => LOCPMval; set => LOCPMval = value; }
        public decimal UCPVal1 { get => UCPVal; set => UCPVal = value; }
        public decimal UUCPVal1 { get => UUCPVal; set => UUCPVal = value; }
        public decimal EstHrsVal { get => estHrsVal; set => estHrsVal = value; }
        public decimal EstLocVal { get => estLocVal; set => estLocVal = value; }
        public decimal EstPMVal { get => estPMVal; set => estPMVal = value; }
        public decimal UUCWTotalVal1 { get => UUCWTotalVal; set => UUCWTotalVal = value; }
        public decimal UAWTotalVal1 { get => UAWTotalVal; set => UAWTotalVal = value; }
        public decimal ECFVal1 { get => ECFVal; set => ECFVal = value; }
        public decimal TCFVal1 { get => TCFVal; set => TCFVal = value; }
    }
}
