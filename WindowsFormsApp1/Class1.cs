using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DaneXML
    {
        private
            int privateData1, privateData2;
        public
            int publicInt1, publicInt2, publicInt3; // komentarz do danych
        public int[] publicTable = new int[4];

        public DaneXML() 
        { 
            privateData1 = 12;
            privateData2 = 133;
            publicInt1 = 1222; 
            publicInt2 = 10987;
            publicInt3 = -1;
            publicTable[0] = publicInt1;
            publicTable[1] = publicInt2;
            publicTable[2] = privateData1;
            publicTable[3] = privateData2;
        }

        override public string ToString()
        {
            return $"The values are: {privateData1}  {privateData2}  {publicInt1}  {publicInt2}  {publicInt3}  {publicTable[0]}  {publicTable[1]}  {publicTable[2]}  {publicTable[3]}. That's it.";
        }

    }
    public class DaneJSON
    { 
        private int privateData1 { get; set; }
        private int privateData2 { get; set; }
        public int publicInt1 { get; set; }
        public int publicInt2 { get; set; }
        public int[] dataTable {  get; set; }

        public DaneJSON() 
        { 
            privateData1 = 12;
            privateData2 = 988;
            publicInt1 = 888;
            publicInt2 = -1;
            dataTable = new int[] { 4, 6, 5645, 111};
        }
        public override string ToString()
        {
            return $"The values are: {privateData1}  {privateData2}  {publicInt1}  {publicInt2}\r\nTable:\r\n{dataTable[0]}\r\n{dataTable[1]}\r\n{dataTable[2]}\r\n{dataTable[3]}\r\nThat's it.";
             
        }
    }
}
