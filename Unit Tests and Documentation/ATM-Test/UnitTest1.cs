using System;
using Xunit;
using Unit_Tests_and_Documentation;

namespace ATM_Test
{
    public class UnitTest1
    {
        
        [Fact]
        public void drawTest1()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance - 500, Program.Withdraw(500));
            
        }
        [Fact]
        public void drawTest2()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance, Program.Withdraw(8000));
            
        }
        [Fact]
        public void drawTest3()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance - 8000, Program.Withdraw(8000));

        }
        [Fact]
        public void depositTest1()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance + 5, Program.Deposit(5));
            
        }
        [Fact]
        public void depositTest2()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance, Program.Deposit(-85));
            
        }
        [Fact]
        public void depositTest3()
        {
            decimal Balance = Program.Balance;
            Assert.Equal(Balance + (-85), Program.Deposit(-85));

        }


    }
}
