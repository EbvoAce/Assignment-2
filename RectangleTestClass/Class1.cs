using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;

namespace RectangleTestClass
{   [TestFixture]
    public class Class1
    {
        [Test]
        public void GetLength1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int output = rectangle.GetLength();
            //Assert
            Assert.AreEqual(1, output);
        }
        [Test]
        public void GetLength2()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2, 1);

            //Act
            int output = rectangle.GetLength();
            //Assert
            Assert.AreEqual(2, output);
        }

        [Test]
        public void GetLength3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(4, 1);
            //Act
            int output = rectangle.GetLength();
            //Assert
            Assert.AreEqual(4, output);
        }

        [Test]
        public void SetLenght1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            //Act
            int output = rectangle.SetLenght(2);
            //Assert
            Assert.AreEqual(2, output);
        }

        [Test]
        public void SetLenght2()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 4);
            //Act
            int output = rectangle.SetLenght(2);
            //Assert
            Assert.AreEqual(2, output);
        }

        [Test]
        public void SetLenght3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            //Act
            int output = rectangle.SetLenght(4);
            //Assert
            Assert.AreEqual(4, output);
        }

        [Test]
        public void Getwidth1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            //Act
            int output = rectangle.GetWidth();
            //Assert
            Assert.AreEqual(1, output);
        }
        [Test]
        public void Getwidth2()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(1,3);
            //Act
            int output = rectangle.GetWidth();
            //Assert
            Assert.AreEqual(3, output);
        }
        [Test]
        public void Getwidth3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(4,4);
            
            //Act
            int output = rectangle.GetWidth();
            //Assert
            Assert.AreEqual(4, output);
        }
        [Test]
        public void Setwidth1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int output = rectangle.SetWidth(2);
            //Assert
            Assert.AreEqual(2, output);
        }
        [Test]
        public void Setwidth2()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2,4);

            //Act
            int output = rectangle.SetWidth(2);
            //Assert
            Assert.AreEqual(2, output);
        }
        [Test]
        public void Setwidth3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(2, 5);

            //Act
            int output = rectangle.SetWidth(3);
            //Assert
            Assert.AreEqual(3, output);
        }
        [Test]
        public void GetPerimeter1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int output = rectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(4, output);
        }
        [Test]

        public void GetPerimeter2()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3,5);

            //Act
            int output = rectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(16, output);
        }
        [Test]
        public void GetPerimeter3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            int input1 = rectangle.SetWidth(5);
            int input2 = rectangle.SetLenght(9);
            //Act
            int output = rectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(28, output);
        }
        [Test]
        public void GetArea1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int output = rectangle.GetArea();
            //Assert
            Assert.AreEqual(1, output);
        }

        [Test]
        public void GetArea2()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(4,4);

            //Act
            int output = rectangle.GetArea();
            //Assert
            Assert.AreEqual(16, output);
        }

        [Test]
        public void GetArea3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            int input1 = rectangle.SetWidth(5);
            int input2 = rectangle.SetLenght(9);

            //Act
            int output = rectangle.GetArea();
            //Assert
            Assert.AreEqual(45, output);
        }



    }
}
