using System;

namespace ContaBancaria.Entities.Exceptions
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message) {}
    }
}