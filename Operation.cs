using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClosedXML;
using ClosedXML.Excel;
using System.Collections;

namespace Seperator
{
    class Operation
    {

        public string Path { get; set; }            //OpenFile()
        public string WsName { get; set; }

        //   public string PathNew { get; set; }

        public XLWorkbook workBook { get; set; }        //OpenFile()
        public IXLWorksheet worksheet { get; set; }

        public XLWorkbook workBookCreated { get; set; }     //Create()
        public IXLWorksheet worksheetCreated { get; set; }

        public int FirstRowUSed { get; set; }           //Calculate()
        public int LastRowUsed { get; set; }
        public int FirstColumnUsed { get; set; }
        public int LastColumnUSed { get; set; }

        public int TotalRows { get; set; }              //Calculate()
        public int TotalColumns { get; set; }

        public int FirstLine { get; set; }
        public int LastLine { get; set; }

        public int Increasement { get; set; }

        public int Part { get; set; }                   //Calculate
        public int Step { get; set; }
        public int Rest { get; set; }

        public string PathNew { get; set; }

        public char CreatedName { get; set; }             //Create()
        public string DefaultWsName = "1";

        internal List<string> Headers = new List<string>();         //Copy()
        internal List<string> Values = new List<string>();          //Copy()-Paste()

        public void OpenFile(string Path, string WsName)
        {
            this.Path = Path;
            this.WsName = WsName;

            workBook = new XLWorkbook(Path);
            worksheet = workBook.Worksheet(WsName);

        }

        public int CalculateStep(int Part)
        {
            this.Part = Part;

            FirstRowUSed = worksheet.FirstRowUsed().RowNumber();
            LastRowUsed = worksheet.LastRowUsed().RowNumber();

            FirstColumnUsed = worksheet.FirstColumnUsed().ColumnNumber();
            LastColumnUSed = worksheet.LastColumnUsed().ColumnNumber();

            TotalRows = LastRowUsed - FirstRowUSed;
            TotalColumns = LastColumnUSed - FirstColumnUsed;

            Rest = TotalRows % Part;

            Step = (TotalRows - Rest) / Part;

            Increasement = Part;

            return Step;
        }

        public void getHeaders()
        {
            for (int i = FirstColumnUsed; i <= LastColumnUSed; i++)
            {
                var index = Convert.ToString(worksheet.Cell(FirstRowUSed, i).Value);
                Headers.Add(index);
            }

            FirstLine = 1;
            LastLine = Increasement;
            CreatedName = 'A';

        }

        public void Copy()
        {

            for (int i = FirstLine + 1; i <= Increasement; i++)
            {
                for (int j = FirstColumnUsed; j <= LastColumnUSed; j++)
                {
                    var val = Convert.ToString(worksheet.Cell(i, j).Value);
                    Values.Add(val);
                }
            }
        }

        public void Create()
        {
            workBookCreated = new XLWorkbook();
            worksheetCreated = workBookCreated.Worksheets.Add(DefaultWsName);

        }

        public void Paste()
        {
            //First paste headers each time

            var counter = 0;
            FirstLine = FirstRowUSed;


            for (int i = FirstLine; i <= LastColumnUSed; i++)
            {
                worksheetCreated.Cell(FirstRowUSed, i).Value = Headers[counter];
                counter++;
            }

            GC.Collect(counter);

            //Paste values end done

            int index = 0;

            for (int i = FirstRowUSed + 1; i <= LastLine; i++)
            {
                for (int j = FirstColumnUsed; j <= LastColumnUSed; j++)
                {
                    worksheetCreated.Cell(i, j).Value = Values[index];
                    index++;
                }
            }

            //Values raised

            GC.Collect(index);

            FirstLine = FirstLine + Part;
            Increasement = Increasement + Part;
        }

        public void Save(string PathNew)
        {

            workBookCreated.SaveAs($"{PathNew}\\{CreatedName}.xlsx");

            //Save them all

            CreatedName++;
            Values.Clear();
        }

    }
}
