using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint1
{
    class DataStorage
    {
        private decimal ei;
        private decimal eo;
        private decimal eiq;
        private decimal ilf;
        private decimal elf;

        private decimal ei_factor;
        private decimal eo_factor;
        private decimal eiq_factor;
        private decimal ilf_factor;
        private decimal elf_factor;

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

    }
}
