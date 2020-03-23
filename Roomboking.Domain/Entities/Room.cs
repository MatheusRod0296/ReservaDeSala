using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roombooking.Domain.Entities
{
    public class Room : Notifiable
    {
        public Room(DateTime startDate, DateTime endDate, string title)
        {
            Id = Guid.NewGuid();
            StartDate = startDate;
            EndDate = endDate;
            Title = title;

            AddNotifications(new ValidationContract()
            .Requires()
            .IsNotNull(startDate, nameof(StartDate), "Horario invalido")
            .IsNotNull(endDate, nameof(EndDate), "Horario invalido")
            .HasMinLen(title, 3, nameof(Title), "Titulo precisa de mais de 3 caracteres")
            .HasMaxLen(title,40, nameof(Title),"titulo nao pode ter mais que 40 caraactesres")
            );

        }

        public Guid Id { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public string Title { get; private set; }


    }
}
