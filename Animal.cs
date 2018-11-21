using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CasusCircustrein.Models
{
    class Animal
    {
        public int diet { get; private set; }
        public int size { get; private set; }

        public Animal(int _size, int _diet)
        {
            size = _size;
            diet = _diet;
        }
    }
}
