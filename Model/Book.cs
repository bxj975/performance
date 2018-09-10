using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Book
    {
        /*名称*/
        private string _bookName;
        public string bookName    //number
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

      
        /*编号*/
        private int _barcode;
        public int barcode      //Id
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        
        
        /*联系人*/
        private string _Name;
        public string Name    //name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        /*类别*/
        private int _bookType;
        public int bookType
        {
            get { return _bookType; }
            set { _bookType = value; }
        }

        /*地区*/
        private string _area;
        public string area   //sex
        {
            get { return _area; }
            set { _area = value; }
        }

        /*归属人*/
        private int _recommend;
        public int recommend    //Recommend
        {
            get { return _recommend; }
            set { _recommend = value; }
        }
        /*归属人*/
        private int _clerk ;
        public int clerk    
        {
            get { return _clerk; }
            set { _clerk = value; }
        }

        /*邮箱*/
        private double _email;
        public double email  //Pay1
        {
            get { return _email; }
            set { _email = value; }
        }

        /*QQ*/
        private double _qq;
        public double qq     //Count1
        {
            get { return _qq; }
            set { _qq = value; }
        }

        /*手机*/
        private double _move;
        public double move   //Team2
        {
            get { return _move; }
            set { _move = value; }
        }
        /*电话*/
        private string _tele;
        public string tele
        {
            get { return _tele; }
            set { _tele = value; }
        }

        /*微信*/
        private double _weixin;
        public double weixin     //Count2
        {
            get { return _weixin; }
            set { _weixin = value; }
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

      

        /*图片*/
        private byte[] _bookPhoto;//数据类型重点
        public byte[] bookPhoto
        {
            get { return _bookPhoto; }
            set { _bookPhoto = value; }
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

        private string _rank;
        public string rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        private bool _team;
        public bool team
        {
            get { return _team; }
            set { _team = value; }
        }

        private bool _type;
        public bool type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _bank;
        public string bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        private string _bankn;
        public string bankn
        {
            get { return _bankn; }
            set { _bankn = value; }
        }

        private string _bankname;
        public string bankname
        {
            get { return _bankname; }
            set { _bankname = value; }
        }

    }
}
