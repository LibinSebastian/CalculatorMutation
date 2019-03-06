using NUnit.Framework;
using SENG40Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseClass
{
    [TestFixture]
    public class TestCaseClass
    {
        //Addition 

        [Test]

        public void DoAddition_Input6and6_Returns12()
        {

            //Arrange

            double nOne = 6;

            double nTwo = 6;

            double expectedResultOf = nOne + nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne,nTwo);
            
            //Act

            double actualResultOf = calTest.DoAddition();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);
        }
        [Test]

        public void DoAddition_Input6point6and6point5_Returns13point1()
        {

            //Arrange

            double nOne = 6.6;

            double nTwo = 6.5;

            double expectedResultOf = nOne + nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoAddition();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }
        [Test]

        public void DoAddition_Input16point6and4point5_Returns21point1()
        {

            //Arrange

            double nOne = 16.6;

            double nTwo = 4.5;


            double expectedResultOf = nOne + nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoAddition();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        //Subtraction

        [Test]

        public void DoSubtraction_Input16and15_Returns1()
        {

            //Arrange

            double nOne = 16;

            double nTwo = 15;

            double expectedResultOf = nOne - nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoSubtraction();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoSubtraction_Input2and1_Returns1()
        {

            //Arrange

            double nOne = 2;

            double nTwo = 1;

            double expectedResultOf = nOne - nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoSubtraction();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoSubtraction_Input1and1_Returns0()
        {

            //Arrange

            double nOne = 1;

            double nTwo = 1;

            double expectedResultOf = nOne - nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoSubtraction();
        
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        //Multiplication


        [Test]

        public void DoMultiplication_Input6and5_Returns30()
        {

            //Arrange

            double nOne = 6;

            double nTwo = 5;

            double expectedResultOf = nOne * nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoMultiplication();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoMultiplication_Input10and5_Returns50()
        {

            //Arrange

            double nOne = 10;

            double nTwo = 5;

            double expectedResultOf = nOne * nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoMultiplication();
        
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoMultiplication_Input8and3_Returns24()
        {

            //Arrange

            double nOne = 8;

            double nTwo = 3;

            double expectedResultOf = nOne * nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoMultiplication();
        
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }


        //Division (Mutated)

        [Test]

        public void DoDivision_Input10and2_Returns5()
        {

            //Arrange

            double nOne = 10;

            double nTwo = 2;

            double expectedResultOf = nOne * nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoDivision();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoDivision_Input5and2_Returns2point5()
        {

            //Arrange

            double nOne = 5;

            double nTwo = 2;


            double expectedResultOf = nOne * nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoDivision();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoDivision_Input100and2_Returns50()
        {

            //Arrange

            double nOne = 100;

            double nTwo = 2;


            double expectedResultOf = nOne * nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoDivision();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        //Division With Given Values

        [Test]

        public void DoDivision_Input1and3_Returns0point33333()
        {

            //Arrange

            double nOne = 1;

            double nTwo = 3;

            double expectedResultOf = nOne / nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoDivision();
        
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }

        [Test]

        public void DoDivision_Input2and1_Returns2()
        {

            //Arrange

            double nOne = 2;

            double nTwo = 1;

            double expectedResultOf = nOne / nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoDivision();
            
            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);

        }
        [Test]
        public void DoDivision_Input9and3_Returns3()
        {

            //Arrange

            double nOne = 9;

            double nTwo = 3;

            double expectedResultOf = nOne / nTwo;

            CalculatorCode calTest = new CalculatorCode(nOne, nTwo);
            
            //Act

            double actualResultOf = calTest.DoDivision();

            //Assert

            Assert.AreEqual(expectedResultOf, actualResultOf);
        }
    }
}
