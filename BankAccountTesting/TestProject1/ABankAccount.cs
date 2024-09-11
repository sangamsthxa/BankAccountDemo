using BankAccountLib;

namespace BankAccountTesting;

public class ABankAccount
{
    

    [Test]
    public void ShouldSetBalanceAndAnnualInterestRateWhenConstructed()
    {
       BankAccount sut = new BankAccount(100.0m,0.01);
       Assert.Multiple(()=>{
       Assert.That(sut.Balance, Is.EqualTo(100.0m));
       Assert.That(sut.AnnualInterestRate, Is.EqualTo(0.01)); //within 
    });
    }
       
}