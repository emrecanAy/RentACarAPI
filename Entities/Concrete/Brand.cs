using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Brand(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Brand() { }

    }
}
