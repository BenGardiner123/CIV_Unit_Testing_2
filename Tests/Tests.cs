using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        [Theory]
        [InlineData(40, 10, 10)]
        [InlineData(1158, 234, 345)]
        [InlineData(69114, 12, 34545)]
        public void CalcRectPerimeter_Test(int expected, int input_one, int input_two)
        {
            var msclib = new GroupTwoFunctions();
            var result = msclib.CalcRectPerimeter(input_one, input_two);
            Assert.Equal(expected, result);
        }    

        [Theory]
        [InlineData(true, 21)]
        [InlineData(true, 66)]
        [InlineData(false, 23)]
        [InlineData(false, 665)] 
        public void IsTriangularNum_Test(bool expected, int input)
        {
            var msclib = new GroupTwoFunctions();
            var result = msclib.IsTriangularNum(input);
            Assert.Equal(expected, result);
        }  

        [Theory]
        [InlineData(0, 32)]
        [InlineData(415, 780)]
        [InlineData(-30, -20)]
        [InlineData(-75, -103)]
        public void FarenheitToCelcius_Test(int expected, int Finput)
        {
            var msclib = new GroupTwoFunctions();
            var result = msclib.FarenheitToCelcius(Finput);
            Assert.Equal(expected, result);
        }  
        

        [Theory]
        [InlineData(true, " sdfh")]
        [InlineData(false, "Moated")]
        [InlineData(true, "Triangles ")]
        [InlineData(false, "Motorboated")]  
        public void CheckWhiteSpace_Test(bool expected, string userInput)
        {
            var msclib = new GroupTwoFunctions();
            var result = msclib.CheckWhiteSpace(userInput);
            Assert.Equal(expected, result);
        }    

        [Theory]
        [InlineData("ThIs", "ThIs")]
        [InlineData("SoMeTiMe", "SoMeTiMe")]
        [InlineData("SoMeThIhNg", "somethihng")]
        [InlineData("UnSeTsTaDnIgN", "unsetstadnign")]
        public void CamelString_Test(string expected, string userInput)
        {
            var msclib = new GroupTwoFunctions();
            var result = msclib.CamelString(userInput);
            Assert.Equal(expected, result);
        }    

        [Theory]
        [InlineData(4, "1123")]
        [InlineData(10, "2398473456")]
        [InlineData(11, "23984734563")]
        [InlineData(6, "123456")]
        public void CountDigits(int expected, string input)
        {
            var msclib = new GroupTwoFunctions();
            var result = msclib.CountDigits(input);
            Assert.Equal(expected, result);
        }      
    }   
}
