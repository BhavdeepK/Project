using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using ConsoleApp1Test;
using NUnit.Framework;

namespace ConsoleApp1Test
{
    [TestFixture]

    class ConsoleApp1Test
    {
        [Test]

        public void GetLength_input4_expectLengthEquals4()

        {

            //Arrange 
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }


                    [Test]
        public void SetLength_input()
        {
            //Arrange
            int l = 2;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(l);

            //Assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void Getwidth_input4_expectWidthequals4()
        {
            //Arrange
            int l = 4;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);


        }

        [Test]

        public void SetWidth_input2_expectWidthEquals2()
        {
            //Arrange
            int l = 2;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(w);

            //Assert
            Assert.AreEqual(width, w);



        }
        [Test]
        public void GetPerimeter_input3_expectWidthEquals12()
        {
            //Arrange
            int l = 3;
            int w = 3;
            int p = 2 * (l + w);
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(Perimeter, p);



        }
        [Test]
        public void GetArea_input3_expectAreaEquals12()
        {
            //Arrange
            int l = 3;
            int w = 3;
            int Area = l * w;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int NewArea = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(NewArea, Area);

        }

    }
} 



   

