using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint1
{
     public class SMIDataStorage
    
    {
        int addedModules=0;
        int deletedModules=0;
        int changedModules=0;

        public int AddedModules { get => addedModules; set => addedModules = value; }
        public int DeletedModules { get => deletedModules; set => deletedModules = value; }
        public int ChangedModules { get => changedModules; set => changedModules = value; }

        // List<decimal> addedModules = new List<decimal>();
        // List<decimal> changedModules = new List<decimal>();
        // List<decimal> deletedModules = new List<decimal>();

        // public List<decimal> AddedModules { get => addedModules; set => addedModules = value; }
        // public List<decimal> ChangedModules { get => changedModules; set => changedModules = value; }
        // public List<decimal> DeletedModules { get => deletedModules; set => deletedModules = value; }
    }
}
