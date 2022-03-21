using System;
using Xunit;
using Unit_Tests_and_Documentation;

namespace ATM_Test
{
    public class UnitTest1
    {
        
        [Fact]
        public void drawTest()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance - 500, Program.Withdraw(500));
            
        }
        [Fact]
        public void drawMoreThanBalance()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance, Program.Withdraw(8000));
            
        }
    
      
        [Fact]
        public void depositTest()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance + 5, Program.Deposit(5));
            
        }
        [Fact]
        public void depositNegativeValue()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance, Program.Deposit(-85));
            
        }
   


    }
}
