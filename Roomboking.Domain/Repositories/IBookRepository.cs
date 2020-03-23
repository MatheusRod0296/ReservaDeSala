using Roombooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roombooking.Domain.Repositories
{
    public interface IBookRepository: IDisposable
    {
        IList<book> GetBooksDataRange(DateTime startDate, DateTime endDate);
    }
}
