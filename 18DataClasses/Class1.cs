using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _17MyAttributes;
namespace _18DataClasses
{
   [Table(TableName = "Employee")]
   public class Emp
    {
        private int _No;

        [Column(ColumnName = "ENo", ColumnType = "int")]
        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        private string _Name;

        [Column(ColumnName = "EName", ColumnType = "varchar")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        

    }
}
