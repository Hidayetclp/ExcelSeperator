using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Collections;
using System.IO;
using ClosedXML;

namespace Seperator
{
    class ExcellOperations
    {

        public string Path { get; set; }
        public string WsName { get; set; }
        public int Part { get; set; }
        public int Step { get; set; }

        public string PathNew { get; set; }

        Operation operation = new Operation();

        public void Start()
        {
            operation.OpenFile(Path, WsName);
            Step = operation.CalculateStep(Part);
            operation.getHeaders();

            for (int i = 0; i <= Step ; i++)
            {
                operation.Copy();
                operation.Create();
                operation.Paste();
                operation.Save(PathNew);
            }
        }
    }
}
