using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    ///BookType 的摘要说明：图书信息实体
    /// </summary>

    public class BookType
    {
        /*图书类别*/
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Number;
        public string Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        /*类别名称*/
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /*可借阅天数*/
        private double _amount;
        public double amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private double _rate;
        public double rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        private double _rateA;
        public double rateA
        {
            get { return _rateA; }
            set { _rateA = value; }
        }

        private double _rateB;
        public double rateB
        {
            get { return _rateB; }
            set { _rateB = value; }
        }
    }
}
