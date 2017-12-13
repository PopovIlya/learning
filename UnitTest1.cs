using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestRightTriangle
{
    [TestClass]
    public class RightTriangleTests
    {

        [TestMethod]
        public void SquareTriangle() //правильно ли считает площадь
        {

            //arrange
            var TestTriangle = new rTriangle();

            //act == 6
            var res = TestTriangle.Main(3, 4, 5);

            //assert
            Assert.AreEqual(6, res, "вычисления производятся верно");
        }

        //[TestMethod]
        //public void HardData() //огроменный такой треугольник
        //{

        //    //arrange
        //    var TestTriangle = new rTriangle();

        //    //act == 6
        //    var res = TestTriangle.Main(6000000000000000000, 6000000000000000000, 8485281374238570000);

        //    //assert
        //    Assert.AreEqual(0, res, "потому что Double, но программа всё равно показывает ответ, а тест не работает, почему?");
        //}

        //[TestMethod]
        //public void TextData() //неверный формат вводимых данных
        //{

        //    //arrange
        //    var TestTriangle = new rTriangle();

        //    //act == 6
        //    var res = TestTriangle.Main("три", "четыре", "пять");

        //    //assert
        //    Assert.AreEqual(0, res, "потому что текст не Double");
        //}

        [TestMethod]
        public void NegativeData() //отрицательные переменные
        {

            //arrange
            var TestTriangle = new rTriangle();

            //act == 6
            var res = TestTriangle.Main(-3, -4, -5);

            //assert
            Assert.AreEqual(0, res, "не существует треугольника с отрицательными сторонами");
        }

        [TestMethod]
        public void squarefaketriangle()  // в случае несуществующего треугольника
        {

            //arrange
            var TestTriangle = new rTriangle();

            //act == 6
            var res = TestTriangle.Main(40, 3, 8888);

            //assert
            Assert.AreEqual(0, res, "тест завершился без ошибки, т.к. любая из сторон треугольника меньше суммы двух других сторон и метод возвращает 0");
        }

        [TestMethod]
        public void squarefakeRighttriangle()  // в случае не прямоугольного треугольника
        {

            //arrange
            var TestTriangle = new rTriangle();

            //act == 6
            var res = TestTriangle.Main(4, 3, 3);

            //assert
            Assert.AreEqual(0, res, "тест завершился без ошибки, т.к. у прямоугольного треугольника квадрат гипотенузы равен сумме квадратов катетов и метод возвращает 0");
        }
    }
}
