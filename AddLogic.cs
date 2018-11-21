using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasusCircustrein.Models;

namespace CasusCircustrein
{
    class AddLogic
    {
        List<Animal> animals = new List<Animal>();

        public AddLogic(List<Animal> _animals)
        {
            animals = _animals;
        }
        
        public void AddAnimal(int size, int diet)
        {
            Animal animal = new Animal(size, diet);
            animals.Add(animal);
        }

        public List<Animal> GetAnimals()
        { return animals; }

        public int CountAnimals(int size, int diet)
        {
            var i = animals.Where(p => p.size == size).Where(p=> p.diet == diet);
            return i.Count();
        }

        public int CountPoints()
        {
            int i = 0;

            foreach (Animal animal in animals)
            {
                i = i + animal.size;
            }

            return i;
        }

        public List<TrainCarriage> FillTrain()
        {
            TrainLogic logic = new TrainLogic(animals);

            return logic.FillTrain();
        }
    }
}
