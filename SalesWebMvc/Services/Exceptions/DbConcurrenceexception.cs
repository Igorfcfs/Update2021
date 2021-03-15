using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrenceexception : ApplicationException
    {
        public DbConcurrenceexception(string message) : base(message)
        {
        }
    }
}
