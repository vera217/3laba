using _3_laba;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace TestProject1
{

    public class UnitTest1
    {
        [Fact]
        public void ParseProduct_InvalidQuantity()
        {
            // Arrange
            string input = "Поступление товаров: 2023.01.05; 'яблоки';"; 

            // Act & Assert
            Assert.Throws<FormatException>(() => Handler.ParseProduct(input));
        }

        [Fact]
        public void ParseReturnAct_InvalidDateFormat()
        {
            // Arrange
            string input = "Акт возврата: 2020-03-01; 'яблоки'; 5; Некачественный товар;"; 

            // Act & Assert
            Assert.Throws<FormatException>(() => Handler.ParseReturnAct(input));
        }
        [Fact]
        public void ParseProduct_InvalidQuantityType()
        {
            // Arrange
            string input = "Поступление товаров: 2023.01.05; 'яблоки'; двадцать;"; 

            // Act & Assert
            Assert.Throws<FormatException>(() => Handler.ParseProduct(input));
        }

        [Fact]

        public void ParseSupplier_InvalidPhoneFormat()
        {
            // Arrange
            string input = "Поставщик: ООО 'Фрукты'; Петр Иванов; 89991234567;"; 

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Handler.ParseSupplier(input));
        }

    }
}
