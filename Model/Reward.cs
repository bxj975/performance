using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Reward 
    {
        /*名称*/
        private int _Id;
        public int Id      //Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /*编号*/
        private int _No;
        public int No      //Id
        {
            get { return _No; }
            set { _No = value; }
        }
        

        /*归属人*/
        private int _custom;
        public int custom    //Recommend
        {
            get { return _custom; }
            set { _custom = value; }
        }
       
        /*微信*/
        private decimal _count;
        public decimal count     //Count2
        {
            get { return _count; }
            set { _count = value; }
        }

        private string _rate;
        public string rate     //Count2
        {
            get { return _rate; }
            set { _rate = value; }
        }

        private decimal _reward;
        public decimal reward     //Count2
        {
            get { return _reward; }
            set { _reward = value; }
        }
      
        /*日期*/
        private DateTime _publishDate = DateTime.Now ;
        public DateTime publishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }
    }
}
