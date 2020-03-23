using Roombooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roombooking.Domain.Entities
{
    public class book
    {
        public book(Room room,  DateTime startTime, DateTime endTime)
        {
            Id = Guid.NewGuid();
            Status = EBookStatus.InProgress;
            Room = room;          
            StartTime = startTime;
            EndTime = endTime;
        }

        public Guid Id { get; private set; }

        public Room Room { get; private set; }

        public EBookStatus Status { get; private set; }

        public DateTime StartTime { get; private set; }

        public DateTime EndTime { get; private set; }

        public void Confirm(IList<DateTime> holidays, IList<DateTime> booksForThisPeriod)
        {
            //verificar se datainicio esta na lista de feriados
            //verificar se datainicio esta na lista de reservas

            if(Status != EBookStatus.InProgress)            
                throw new Exception("Error");

            Status = EBookStatus.Reserrved;
        }

        public void MarkInProgress()
        {
            Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            if ((StartTime - DateTime.Now).Hours < 2)
                throw new Exception("só pode cancelar com duas horas de antecedencia");

            Status = EBookStatus.Canceled;
        }


        public void MarkCompleted()
        {
            Status = EBookStatus.Completed;
        }

    }
}
