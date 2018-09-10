using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Adjust 
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
        
        private int _custom1;
        public int custom1    //Recommend
        {
            get { return _custom1; }
            set { _custom1 = value; }
        }
        
        private string _custom2;
        public string custom2    //Recommend
        {
            get { return _custom2; }
            set { _custom2 = value; }
        }
        
        
        private int _clerk ;
        public int clerk    
        {
            get { return _clerk; }
            set { _clerk = value; }
        }        

        private int _product;
        public int product
        {
            get { return _product; }
            set { _product = value; }
        }
       
        /*微信*/
        private decimal _amount;
        public decimal amount     //Count2
        {
            get { return _amount; }
            set { _amount = value; }
        }
       
        /*备注*/
        private string _note;
        public string note
        {
            get { return _note; }
            set { _note = value; }
        }

        /*日期*/
        private DateTime _publishDate = DateTime.Now ;
        public DateTime publishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }

        private string _adjust;
        public string adjust
        {
            get { return _adjust; }
            set { _adjust = value; }
        }


        private string _rank;
        public string rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        private string _team;
        public string team
        {
            get { return _team; }
            set { _team = value; }
        }

        /*地址*/
        private string _address;
        public string address  //Person
        {
            get { return _address; }
            set { _address = value; }
        }

        /*网址*/
        private double _www;
        public double www    //Pay2
        {
            get { return _www; }
            set { _www = value; }
        }
    }
}
