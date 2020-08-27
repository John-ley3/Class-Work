using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling.Exceptions
{
    public class OverdraftException : Exception
    {
        private decimal _OverdraftAmount { get; set; } = 0.0M;
        public decimal OverDraftAmount
        {
            get { return _OverdraftAmount; }
        }
        public OverdraftException(string message, decimal overdraftAmount) :base(message)
        {
            _OverdraftAmount = overdraftAmount;
        }
    }
}
