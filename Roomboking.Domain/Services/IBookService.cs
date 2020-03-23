using System;
using System.Collections.Generic;
using System.Text;

namespace Roombooking.Domain.Services
{
    public interface IBookService : IDisposable
    {
        void PlaceBook(DateTime startDate, DateTime endDate,  Guid room);
    }
}
