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
            msclib = new GroupTwoFunctions();
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
            msclib = new GroupTwoFunctions();
            var result = msclib.IsTriangularNum(input);
            Assert.Equal(expected, result);
        }  

        [Theory]
        [InlineData(32, 0)]
        [InlineData(780, 415.556)]
        [InlineData(-22, -30)]
        [InlineData(-103, -75)]
        public void FarenheitToCelcius_Test(int expected, int Finput)
        {
            msclib = new GroupTwoFunctions();
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
            msclib = new GroupTwoFunctions();
            var result = msclib.CheckWhiteSpace(userInput);
            Assert.Equal(expected, result);
        }    

        [Theory]
        [InlineData("ThIs", "ThIs")]
        [InlineData("SoMeTiMe", "SoMeTiMe")]
        [InlineData("SoMeThIhNg", "somethihng")]
        [InlineData("UnSeTsTaDnIgN", "unserstadnign")]
        public void CamelString_Test(string expected, string userInput)
        {
            msclib = new GroupTwoFunctions();
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
            msclib = new GroupTwoFunctions();
            var result = msclib.CountDigits(userInput);
            Assert.Equal(expected, result);
        }      
    }   
}
