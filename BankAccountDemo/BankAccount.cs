namespace BankAccountLib;

public class BankAccount
{
    public BankAccount(decimal balance, double annualInterestRate)
    {
        Balance = balance;
        AnnualInterestRate = annualInterestRate;
    }

    public decimal Balance { get; }
    public double AnnualInterestRate { get; }
}
