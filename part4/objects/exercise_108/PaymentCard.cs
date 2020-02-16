using System;
namespace exercise_108
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {      
            this.balance =  openingBalance;
        }
        public void EatLunch()
        {
            if (balance > 10)
            this.balance = this.balance -10.60; 
        }
        public void DrinkCoffee()
         {
            if (balance > 2.0)
            this.balance = this.balance -2.0;
         }
        public override string ToString()
        {
           return "The card has a balance of " + balance + " euros";
        }
    }
}