using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    public class Organization
    {
        private string _name;
        private DateTime _dateOfEstablishment;
        private string _currentCensus;
        private List<Terrorist> _listOfTerrorist;
        public Organization(string name, DateTime dateOfEstablishment, string currentCensus)
        {
            _name = name;
            _dateOfEstablishment = dateOfEstablishment;
            _currentCensus = currentCensus;
            _listOfTerrorist = new List<Terrorist>();
        }

        public void AddTerrorist(Terrorist t)
        {
            _listOfTerrorist.Add(t);
        }

        public string GetName() => _name;
        public DateTime GetDateOfEstablishment() => _dateOfEstablishment;
        public string GetCurrentCensus() => _currentCensus;



    }

    internal class Hamas : Organization
    {
        string DateOfEstablishment = "10.12.1987";
        string CurrentCensus = "Raed Saad";
        private List<Terrorist> listOfTerrorist = new List<Terrorist>();


    }
}
