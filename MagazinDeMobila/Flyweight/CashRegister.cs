using System;
using System.Collections.Generic;

namespace MagazinDeMobila.Flyweight
{
   public abstract class CashRegister
    {
        private readonly Dictionary<double, Money> _sharedMoneyMap;
        private Money _unsharedMoney;

        public CashRegister()
        {
            _sharedMoneyMap = new Dictionary<double, Money>();
            _unsharedMoney = null;
        }

        protected Money Lookup(double value)
        {
            if (IsSharedValue(value))
            {
                if (!_sharedMoneyMap.ContainsKey(value))
                {
                    _sharedMoneyMap.Add(value, CreateNewMoney());
                }
                return _sharedMoneyMap[value];
            }
            if (_unsharedMoney == null)
            {
                _unsharedMoney = CreateNewMoney();

            }
            return _unsharedMoney;
        }

        public void CashIn(double value)
        {
            Money money = Lookup(value);
            money.TotalCache += value;
        }

        public void CashOut(double value)
        {
            Money money = Lookup(value);
            if (money.TotalCache >= value)
            {
                money.TotalCache -= value;
            }
            else
            {
                Console.WriteLine("Don't have the requested value.");
            }
        }
        public double GetTotalCash()
        {
            double sum = 0;
            foreach (var it in _sharedMoneyMap)
            {
                sum += it.Value.TotalCache;
            }

            if (_unsharedMoney != null)
            {
                sum += _unsharedMoney.TotalCache;
            }
            return sum;
        }

        public abstract Money CreateNewMoney();
        public abstract bool IsSharedValue(double value);
    }
}