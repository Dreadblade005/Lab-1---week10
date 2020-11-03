/// Lab 9
/// File Name: Payemnts
/// @author: Dakota Durst
/// Date: November 1st, 2020
///
/// Problem Statement: define a class called payment that stores some payments and outputs the description
/// 
///
///
/// Overall Plan:
/// 1) create main payment class
/// 2) create main cash payment class
/// 3) create credit card payment
/// 4) test out cash payments with 2 different tests
/// 5) similarly test out credit payments with 2 different tests
using System;

namespace part_1 //lab1 week 10
{
    class Program
    {
        public class Payment
        {
            private double amount;


        public void setAmount(double amount)
        {
            this.amount = amount;
        }
        public double getAmount()
        {
            return amount;
        }
        public void paymentDetails()
            {
                Console.WriteLine("The payment of amount is: $" + this.amount);
            }
      }//payment
        public class CashPayment : Payment
        {
            private double money;
            public void MoneyPayment(double cash)
            {
                money = cash;
            }
            public void PaymentDetails()
            {
                Console.WriteLine("The payment of cash:  $" + money);
            }

        }
        public class CreditCardPayment: Payment
        {
            private double payment;
            private String name;
            private int cardNumber;
            private String expDate;
           public void CreditCard(double payment, String name, String expDate, int cardNumber)
            {
                this.payment = payment;
                this.cardNumber = cardNumber;
                this.expDate = expDate;
                this.name = name;
            }
            //include construct
            public void PaymentDetails()
            {
                Console.WriteLine("The payment of $" + payment + " through the card " + cardNumber
        + ",  and expire date " + expDate + ", and the owner name: " + this.name + ".");
            }
        }
        public class test
        {
            static void Main(string[] args)
            {
                CashPayment p1 = new CashPayment();
                p1.MoneyPayment(15);
                CashPayment p2 = new CashPayment();
                p2.MoneyPayment(77.77);
                p1.PaymentDetails();
                p2.PaymentDetails();

                CreditCardPayment ccp1 = new CreditCardPayment();
                ccp1.CreditCard(2.12, "George Bush", "11/27", 987654321);
                CreditCardPayment ccp2 = new CreditCardPayment();
                ccp2.CreditCard(126.44, "Bryan Henson", "10/23", 123456789);
                ccp1.PaymentDetails();
                ccp2.PaymentDetails();


            }
        }//main
    }//program


}
