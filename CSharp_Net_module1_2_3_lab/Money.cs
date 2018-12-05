using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU


    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public decimal Amount { get; set; }
        public EnumCurrencyTypes CurrencyType { get; set; }

        // 3) declare parameter constructor for properties initialization
        public Money(decimal amount, EnumCurrencyTypes currencyType)
        {
            Amount = amount;
            CurrencyType = currencyType;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static decimal operator +(Money money1, Money money2)
        {
            return money1.CurrencyType == money2.CurrencyType ? money1.Amount + money2.Amount : 0;
        }
        public static Money operator +(Money money1, decimal value)
        {
            money1.Amount += value;
            return money1;
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money money)
        {
            money.Amount--;
            return money;
        }
        public static Money operator ++(Money money)
        {
            money.Amount++;
            return money;
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money m1, int value)
        {
            m1.Amount *= value;
            return m1;
        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator > (Money m1, Money m2)
        {
            return m1.CurrencyType == m2.CurrencyType ? m1.Amount > m2.Amount : false;
        }
        public static bool operator <(Money m1, Money m2)
        {
            return m1.CurrencyType == m2.CurrencyType ? m1.Amount < m2.Amount : false;
        }
        public static bool operator ==(Money m1, Money m2)
        {
            return m1.CurrencyType == m2.CurrencyType ? m1.Amount == m2.Amount : false;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return m1.CurrencyType == m2.CurrencyType ? m1.Amount != m2.Amount : false;
        }

        public static bool operator >(Money m1, string value)
        {
            return m1.Amount > decimal.Parse(value);
        }
        public static bool operator <(Money m1, string value)
        {
            return m1.Amount < decimal.Parse(value);
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money m)
        {
            return m.CurrencyType == EnumCurrencyTypes.UAH;
        }
        public static bool operator false(Money m)
        {
            return m.CurrencyType != EnumCurrencyTypes.UAH;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        //public static implicit operator double(Money m)
        //{
        //    return (double)m.Amount;
        //}

        public static explicit operator double(Money m)
        {
            return (double)m.Amount;
        }

        public static explicit operator string(Money m)
        {
            return $"{m.Amount} {m.CurrencyType}";
        }
        /*
полный вариант
  public static implicit operator string(Money money)
        {
           
            return $"{money.CurrencyType.ToString()} {money.Amount}";
        }

        //и вайса верса
        public static implicit operator Money(string value)
        {
           
            // Enum.Parse - механизм приведения строки к енумке: в метод передали тип и строку, на выходе получили object который привели к нужному типу
            //string.Split() - получения массива стрингов по разделителю (пробел, запятая и т.п.)
            //value.Split()[0] вернет нам значение до пробела
            //value.Split()[1] вернет нам значение после пробела
            string strCur = value.Split()[0];
            CurrencyTypes currency = (CurrencyTypes)Enum.Parse(typeof(CurrencyTypes), strCur);
            string strAmount = value.Split()[1];
            decimal amount = decimal.Parse(strAmount);
            return new Money(amount, currency);
        }
		*/
    }
}
