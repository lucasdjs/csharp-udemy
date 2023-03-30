using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurencyException: ApplicationException
    {
        public DbConcurencyException(string message): base(message)
        {

        }
    }
}
