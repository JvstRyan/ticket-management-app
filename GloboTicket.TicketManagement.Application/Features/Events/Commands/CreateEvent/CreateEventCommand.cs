﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommand : IRequest<Guid>
    {
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default;

        public override string ToString()
        {
            return $"Event name: {Name}; Price: {Price}; By: {Artist}; On: {Date.ToShortDateString()}; Description: {Description};";

        }
    }
}
