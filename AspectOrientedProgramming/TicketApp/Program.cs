using AspectOrientedProgramming.Entities;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.TicketApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ticket = new Ticket
            {
                Id = 1,
                Subject = "subject",
                Description = "description",
                CustomerId=1,
                LevelOfDifficulty="2",
                Priority="1",
                CreateDate=DateTime.Now,

            };


            var builder = new ContainerBuilder();
            builder.RegisterModule(new DefaultModule());

            var container = builder.Build();
            var willBeIntercepted = container.Resolve<ITicket>();
            willBeIntercepted.Add(ticket.Id, ticket.Subject, ticket.Description, ticket.CustomerId,ticket.LevelOfDifficulty,ticket.Priority,ticket.CreateDate);

            Console.ReadKey();
        }
    }
}
