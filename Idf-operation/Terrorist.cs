using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    internal class Terrorist
    {
        private string _name;      
        private int _rank;      
        private bool _status;     
        private string _wepon;
       

        public Terrorist(string name, int rank, bool status, string wepon)
        {
            _name = name;
            _rank = rank;
            _status = status;
            _wepon = wepon;
        }
        public string getname()
        {
            return _name;
        }
        public void setname(string name)
        {
            _name = name;
        }

        public int getrank()
        {
            return _rank;
        }
        public void setrank(int rank)
        {
            _rank = rank;
        }


        public bool getstatus()
        {
            return _status;
        }
        public void setstatus(bool status)
        {
            _status = status;
        }

        public string getwepon()
        {
            return _wepon;
        }
        public void setwepon(string wepon)
        {
            _wepon = wepon;
        }


    }


}

