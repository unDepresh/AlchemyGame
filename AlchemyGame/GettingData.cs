using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyGame
{
    internal class GettingData
    {
        private string playerValue;
        private string playerValueCase1;
        public string PlayerValue
        {
            get 
            {
                if (playerValue != null)
                {
                    return playerValue;
                }
                else 
                {
                    playerValue = string.Empty;
                    return playerValue;
                }
            }
            set
            {
                playerValue = value;
            }
        }
        public string PlayerValueCase1
        {
            get
            {
                if (playerValueCase1 != null)
                {
                    return playerValueCase1;
                }
                else
                {
                    playerValueCase1 = string.Empty;
                    return playerValueCase1;
                }
            }
            set
            {
                playerValueCase1 = value;
            }
        }
    }
}
