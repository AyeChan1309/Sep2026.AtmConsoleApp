using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.AtmConsoleApp
{
    public class AtmService
    {
        public static List<AccountDto> Accounts = new List<AccountDto>();

        public void CreateAccount(string AccountNumber, string AccountHolderName, decimal Balance, string Pin)
        {
            int maxId = Accounts.Count == 0 ? 0 : Accounts.Max(x => x.Id);
            AccountDto account = new AccountDto
            {
                Id = maxId + 1,
                AccountNumber = AccountNumber,
                AccountHolderName = AccountHolderName,
                Balance = Balance,
                Pin = Pin
            };
            Accounts.Add(account);
        }

        public void ShowAllAccounts()
        {
            foreach (var account in Accounts)
            {
                Console.WriteLine($"Id: {account.Id} | Account Number: {account.AccountNumber} | Account Holder Name: {account.AccountHolderName} | Balance: {account.Balance}");
            }
        }

        public void Login(string accountNumber, string pin)
        {
            AccountDto account = AtmService.Accounts.Where(x => x.AccountNumber == accountNumber && x.Pin == pin).FirstOrDefault();
            if (account != null)
            {
                Console.WriteLine($"Login successful! Welcome, {account.AccountHolderName}.");
            }
            else
            {
                Console.WriteLine("Invalid account number or PIN. Please try again.");
            }
        }
    }
}
