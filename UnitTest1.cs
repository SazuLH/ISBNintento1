using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestISBN
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod10Validos()
        {
            int ISBN10 = 0;
            bool ISBNvalid = false;
            int[] digit = {0, 7, 1, 6, 7, 0, 3, 4, 4, 0};

            

            ISBN10 = ((digit[0] * 10) + (digit[1] * 9) + (digit[2] * 8) + (digit[3] * 7) + (digit[4] * 6) + (digit[5] * 5) + (digit[6] * 4) + (digit[7] * 3) + (digit[8] * 2) + (digit[9] * 1));
            ISBNvalid = (ISBN10 % 11 == 0);
            
            if (ISBN10 == 0)
            {
                Assert.IsTrue(ISBNvalid);
            }
  
        }
        [TestMethod]
        public void TestMethod10Invalidos()
        {
            int ISBN10 = 0;
            bool ISBNinvalid = false;
            int[] digit = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};



            ISBN10 = ((digit[0] * 10) + (digit[1] * 9) + (digit[2] * 8) + (digit[3] * 7) + (digit[4] * 6) + (digit[5] * 5) + (digit[6] * 4) + (digit[7] * 3) + (digit[8] * 2) + (digit[9] * 1));
            ISBNinvalid = (ISBN10 % 11 == 0);

            if (ISBN10 == 0)
            {
                Assert.IsFalse(ISBNinvalid);
            }
        }
        [TestMethod]
        public void TestMethod13Validos()
        {
            int ISBN13 = 0;
            bool ISBNvalid = false;
            int[] digit13 = {9, 7, 8, 0, 7, 1, 6, 7, 0, 3, 4, 4, 0};



            ISBN13 = ((digit13[0] * 1) + (digit13[1] * 3) + (digit13[2] * 1) + (digit13[3] * 3) + (digit13[4] * 1) + (digit13[5] * 3) + (digit13[6] * 1) + (digit13[7] * 3) + (digit13[8] * 1) + (digit13[9] * 3) + (digit13[10] * 1) + (digit13[11] * 3) + (digit13[12] * 1));
            ISBNvalid = (ISBN13 % 10 == 0);

        
            else if (ISBN13 == 0)
            {
                Assert.IsTrue(ISBNvalid);
            }
        }
        [TestMethod]
        public void TestMethod13Invalidos()
        {
            int ISBN13 = 0;
            bool ISBNinvalid = false;
            int[] digit13 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 4, 2, 5 };



            ISBN13 = ((digit13[0] * 1) + (digit13[1] * 3) + (digit13[2] * 1) + (digit13[3] * 3) + (digit13[4] * 1) + (digit13[5] * 3) + (digit13[6] * 1) + (digit13[7] * 3) + (digit13[8] * 1) + (digit13[9] * 3) + (digit13[10] * 1) + (digit13[11] * 3) + (digit13[12] * 1));
            ISBNinvalid = (ISBN13 % 10 == 0);



            else if (ISBN13 != 0)
            {
                Assert.IsTrue(ISBNinvalid);
            }
        }
    }
}
