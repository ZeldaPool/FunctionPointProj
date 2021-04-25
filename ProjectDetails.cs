﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint1
{
    class ProjectDetails
    {
        private string projectName = "CECS 543 Metric Suite";

        private string productName = "";

        private string creatorName = "";

        private string comment="";

        List<DataStorage> dslist = new List<DataStorage>();

        List<UCPDataStorage> ucplist = new List<UCPDataStorage>();

        List<List<SMIDataStorage>> smilist = new List<List<SMIDataStorage>>();

        public string ProjectName { get => projectName; set => projectName = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string CreatorName { get => creatorName; set => creatorName = value; }
        public string Comment { get => comment; set => comment = value; }
        public List<DataStorage> Dslist { get => dslist; set => dslist = value; }
        public List<UCPDataStorage> Ucplist { get => ucplist; set => ucplist = value; }
        public List<List<SMIDataStorage>> Smilist { get => smilist; set => smilist = value; }
    }
}
