using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class ATM
    {
        public static int Banknote(int amount)
        {

            const int hundred = 100;
            const int fifty = 50;
            const int twenty = 20;
            const int ten = 10;
            const int five = 5;
            const int one = 1;

            if (amount >= hundred)
            {
                return hundred;
            }
            if (amount >= fifty)
            {
                return fifty;
            }
            if (amount >= twenty)
            {
                return twenty;
            }
            if (amount >= ten)
            {
                return ten;
            }
            if (amount >= five)
            {
                return five;
            }
            if (amount >= one)
            {
                return one;
            }
            return 0;
        }
    }
}
