using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasusCircustrein.Models;

namespace CasusCircustrein.Models
{
    class TrainCarriage
    {
        private int maxpoints = 10;
        private int points = 0;
        private List<Animal> animals = new List<Animal>();

        public TrainCarriage()
        {
            points = 0;
        }

        public bool AddAnimal(Animal animal)
        {
            if (CheckSize(animal) == true)
            {
                if (points + animal.size <= maxpoints)
                {
                    animals.Add(animal);
                    points = points + animal.size;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }

        public bool CheckSize(Animal animal)
        {
            if (animal.diet == 1)
            {
                if (animal.size == 5)
                {
                    foreach (Animal _animal in animals)
                    {
                        if (animals != null)
                        {
                            return false;
                        }
                        else
                        { return true; }
                    }
                }
                else if (animal.size == 3)
                {
                    foreach (Animal _animal in animals)
                    {
                        if (_animal.size == 5 && animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 3 && animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 1)
                        {
                            return false;
                        }
                        else
                        { return true; }
                    }
                }
                else if (animal.size == 1)
                {
                    foreach (Animal _animal in animals)
                    {
                        if (_animal.size == 5 && animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 3 && animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (animal.size == 5)
                {
                    foreach (Animal _animal in animals)
                    {
                        if (_animal.size == 5 && _animal.diet == 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else if (animal.size == 3)
                {
                    foreach (Animal _animal in animals)
                    {
                        if (_animal.size == 5 && _animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 3 && _animal.diet == 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else if (animal.size == 1)
                {
                    foreach (Animal _animal in animals)
                    {
                        if (_animal.size == 5 && _animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 3 && _animal.diet == 1)
                        {
                            return false;
                        }
                        else if (_animal.size == 1 && _animal.diet == 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }

            return true;           
        }
    }
}

