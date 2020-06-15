using organikBahce.Entities.Conrete.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public bool isComplated { get; set; }
        public string UserId { get; set; }
        public StatusType StatusType { get; set; }
        public int AnswerId { get; set; }

        public Ticket AnswerTicket { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
