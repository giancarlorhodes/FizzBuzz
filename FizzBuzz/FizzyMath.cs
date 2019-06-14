namespace FizzBuzz
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class FizzyMath
    {
        public bool IsFizz(int iNumber)
        {
            if (iNumber % 3 == 0)
            {
                return true;
            }
            else {

                return false;
            }
        }

        public bool IsBuzz(int iNumber)
        {

            if (iNumber % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsFizzBuzz(int iNumber)
        {

            if ((iNumber % 5 == 0) && (iNumber % 3 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsPrintableNumber(int iNumber) {

            bool _printable = !IsFizzBuzz(iNumber) &&
                                !IsFizz(iNumber) && !IsBuzz(iNumber);


            return _printable;
        }


    }
}
