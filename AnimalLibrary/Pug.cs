using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {

        public bool IsSmall { get; set; } = true;

        public Pug(string Name):base (Name) {
            IsSmall = true;
            Muzzle = MuzzleType.Collapsed;
            }

        public Pug() : this("Spot") {

        }
        // had to add the override to the method to get the specific dog vs just dog alone

        public override string GetTypeOfDog() {
            return "Pug";
        }
    }

    }

