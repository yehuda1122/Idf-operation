using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    internal class AttackManager
    {
        public List<Terrorist> _terrorists;
        
        public AttackManager(List<Terrorist> terrorists)
        {
            _terrorists = terrorists;
        }
        public void ExecuteAttacks()
        {
            foreach( var terorist  in _terrorists ) 
            {
                if(terorist.getwepon() == "gun" 
        }
    }
}
