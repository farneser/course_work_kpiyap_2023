using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthmatedWorkplace.Data.Models
{
    public class Entity
    {
        [Key] public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool Type { get; set; }
        public int Num { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }

        public Entity()
        {
            Name = "";
            Description = "";
            Type = false;
            Num = 0;
            Date = DateTime.Now;
        }
    }
}