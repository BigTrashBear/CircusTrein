using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasusCircustrein.Models;

namespace CasusCircustrein
{
    class TrainLogic
    {
        private List<Animal> animals = new List<Animal>();

        public TrainLogic(List<Animal> _animals)
        {
            animals = _animals;
        }

        public List<TrainCarriage> FillTrain()
        {
            List<TrainCarriage> train = new List<TrainCarriage>();

            TrainCarriage car = new TrainCarriage();

            foreach (Animal animal in animals)
            {
                if (car.AddAnimal(animal) != true)
                {
                    train.Add(car);
                    car = new TrainCarriage();
                    car.AddAnimal(animal);
                }
            }

            train.Add(car);
            return train;
        }
    }
}

