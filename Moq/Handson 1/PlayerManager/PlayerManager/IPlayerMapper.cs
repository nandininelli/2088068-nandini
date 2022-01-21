using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManager
{
   public  interface IPlayerMapper
    {
        bool IsPlayerNameExistsInDb(string name);



        void AddNewPlayerIntoDb(string name);
    }
}
