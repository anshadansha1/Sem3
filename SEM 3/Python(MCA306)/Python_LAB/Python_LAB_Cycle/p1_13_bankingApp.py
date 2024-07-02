#Create a simple banking application by using inheritance.


class Account:
    def __init__(self, owner, balance=0.0):
        self.owner = owner
        self.balance = balance

    def deposit(self, amount):
        if amount > 0:
            self.balance += amount
            print(f"Deposited {amount}. New balance is {self.balance}.")
        else:
            print("Deposit amount must be positive.")

    def withdraw(self, amount):
        if amount > 0:
            if self.balance >= amount:
                self.balance -= amount
                print(f"Withdrew {amount}. New balance is {self.balance}.")
            else:
                print("Insufficient funds.")
        else:
            print("Withdrawal amount must be positive.")

    def display_balance(self):
        print(f"Account owner: {self.owner}, Balance: {self.balance}")

class SavingsAccount(Account):
    def __init__(self, owner, balance=0.0, interest_rate=0.01):
        super().__init__(owner, balance)
        self.interest_rate = interest_rate

    def add_interest(self):
        interest = self.balance * self.interest_rate
        self.balance += interest
        print(f"Interest added. New balance is {self.balance}.")

class CurrentAccount(Account):
    def __init__(self, owner, balance=0.0, overdraft_limit=500):
        super().__init__(owner, balance)
        self.overdraft_limit = overdraft_limit

    def withdraw(self, amount):
        if amount > 0:
            if self.balance + self.overdraft_limit >= amount:
                self.balance -= amount
                print(f"Withdrew {amount}. New balance is {self.balance}.")
            else:
                print("Overdraft limit exceeded.")
        else:
            print("Withdrawal amount must be positive.")

def main():
    accounts = {}

    while True:
        print("\nBanking System Menu:")
        print("1. Create Savings Account")
        print("2. Create Current Account")
        print("3. Deposit")
        print("4. Withdraw")
        print("5. Display Balance")
        print("6. Add Interest (Savings Account only)")
        print("7. Exit")
        
        choice = input("\nEnter your choice: ")

        if choice == '1':
            owner = input("\nEnter account owner's name: ")
            balance = float(input("\nEnter initial balance: "))
            interest_rate = float(input("\nEnter interest rate: "))
            accounts[owner] = SavingsAccount(owner, balance, interest_rate)
            print("\nSavings account created successfully.")

        elif choice == '2':
            owner = input("\nEnter account owner's name: ")
            balance = float(input("\nEnter initial balance: "))
            overdraft_limit = float(input("\nEnter overdraft limit: "))
            accounts[owner] = CurrentAccount(owner, balance, overdraft_limit)
            print("\nCurrent account created successfully.")

        elif choice == '3':
            owner = input("\nEnter account owner's name: ")
            if owner in accounts:
                amount = float(input("\nEnter amount to deposit: "))
                accounts[owner].deposit(amount)
            else:
                print("\nAccount not found.")

        elif choice == '4':
            owner = input("\nEnter account owner's name: ")
            if owner in accounts:
                amount = float(input("\nEnter amount to withdraw: "))
                accounts[owner].withdraw(amount)
            else:
                print("\nAccount not found.")

        elif choice == '5':
            owner = input("\nEnter account owner's name: ")
            if owner in accounts:
                accounts[owner].display_balance()
            else:
                print("\nAccount not found.")

        elif choice == '6':
            owner = input("\nEnter account owner's name: ")
            if owner in accounts:
                account = accounts[owner]
                if isinstance(account, SavingsAccount):
                    account.add_interest()
                else:
                    print("\nInterest can only be added to savings accounts.")
            else:
                print("\nAccount not found.")

        elif choice == '7':
            print("\nExiting the program.")
            break

        else:
            print("\nInvalid choice. Please try again.")

if __name__ == "__main__":
    main()
