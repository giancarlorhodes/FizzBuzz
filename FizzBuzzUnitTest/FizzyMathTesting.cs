using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class FizzyMathTesting
    {
        [TestMethod]
        public void Is_Divisible_By_Three()
        {
            // arrange
            int _numbertodivide = 3;

            // act 
            FizzyMath _fm = new FizzyMath();
            bool _isFizzy = _fm.IsFizz(_numbertodivide);

            // assert
            Assert.IsTrue(_isFizzy);
            
        }

        [TestMethod]
        public void Is_Divisible_By_Five()
        {

            // arrange
            int _numbertodivide = 5;

            // act 
            FizzyMath _fm = new FizzyMath();
            bool _isBuzzy= _fm.IsBuzz(_numbertodivide);

            // assert
            Assert.IsTrue(_isBuzzy);
        }

        [TestMethod]
        public void Is_Divisible_By_Three_And_Five()
        {

            // arrange
            int _numbertodivide = 15;

            // act 
            FizzyMath _fm = new FizzyMath();
            bool _isFizzyBuzzy = _fm.IsBuzz(_numbertodivide);

            // assert
            Assert.IsTrue(_isFizzyBuzzy);
        }


        [TestMethod]
        public void Is_Printable_Number()
        {

            // arrange
            int _numbertodivide = 13;

            // act
            FizzyMath _fm = new FizzyMath();
            bool _returnValue = _fm.IsPrintableNumber(_numbertodivide);

            // assert
            Assert.IsTrue(_returnValue);

        }



    }
}
