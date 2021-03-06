using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint1
{
    public class DataStorage
    {
        private decimal ei=0;
        private decimal eo=0;
        private decimal eiq=0;
        private decimal ilf=0;
        private decimal elf=0;

        private decimal ei_factor=4;
        private decimal eo_factor=5;
        private decimal eiq_factor=4;
        private decimal ilf_factor=10;
        private decimal elf_factor=7;

        private string langSel = "none";

        private decimal vaftotal = 0;

        private int codeSize = 0;

        private int eiTotal = 0;
        private int eoTotal = 0;
        private int eiqTotal = 0;
        private int ilfTotal = 0;
        private int elfTotal = 0;

        private decimal computedFP = 0;



        List<int> vafVals = new List<int>();

        public decimal Ei { get => ei; set => ei = value; }
        public decimal Eo { get => eo; set => eo = value; }
        public decimal Eiq { get => eiq; set => eiq = value; }
        public decimal Ilf { get => ilf; set => ilf = value; }
        public decimal Elf { get => elf; set => elf = value; }
        public decimal Ei_factor { get => ei_factor; set => ei_factor = value; }
        public decimal Eo_factor { get => eo_factor; set => eo_factor = value; }
        public decimal Eiq_factor { get => eiq_factor; set => eiq_factor = value; }
        public decimal Ilf_factor { get => ilf_factor; set => ilf_factor = value; }
        public decimal Elf_factor { get => elf_factor; set => elf_factor = value; }
        public string LangSel { get => langSel; set => langSel = value; }
        public decimal Vaftotal { get => vaftotal; set => vaftotal = value; }
        public int CodeSize { get => codeSize; set => codeSize = value; }
        public List<int> VafVals { get => vafVals; set => vafVals = value; }
        public int EiTotal { get => eiTotal; set => eiTotal = value; }
        public int EoTotal { get => eoTotal; set => eoTotal = value; }
        public int EiqTotal { get => eiqTotal; set => eiqTotal = value; }
        public int IlfTotal { get => ilfTotal; set => ilfTotal = value; }
        public int ElfTotal { get => elfTotal; set => elfTotal = value; }
        public decimal ComputedFP { get => computedFP; set => computedFP = value; }
    }
}
