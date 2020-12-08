using System;

namespace S11V146_Exception.Entities.Excpetion
{
    class DomainExcpetion : ApplicationException
    {
        public DomainExcpetion(string message) : base(message)
        {
        }
    }
}
