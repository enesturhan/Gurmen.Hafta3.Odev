using AspectOrientedProgramming.Core.Aspect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.Entities
{
    public interface ITicket
    {
        void Add(int id, string subject, string description,int customerId,string levelofDifficulty,string priority,DateTime createdDate);
        void Update(int id, string subject, string description, int customerId, string levelofDifficulty, string priority, DateTime createdDate);
    }
    public class Ticket:ITicket
    {

        public int Id { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public int CustomerId { get; set; }
        public string LevelOfDifficulty { get; set; }

        public string Priority { get; set; }

        public DateTime CreateDate { get; set; }


        [DefensiveProgrammingAspect(Priority = 1)]
        [InterceptionAspect(Priority = 2)]
        public void Add(int id, string subject, string description, int customerId, string levelofDifficulty, string priority, DateTime createdDate)
        {
            Console.WriteLine("eklendi");
        }

        [DefensiveProgrammingAspect(Priority = 1)]
        [InterceptionAspect(Priority = 2)]
        public void Update(int id, string subject, string description, int customerId, string levelofDifficulty, string priority, DateTime createdDate)
        {
            Console.WriteLine("güncellendi");
        }
    }
}
