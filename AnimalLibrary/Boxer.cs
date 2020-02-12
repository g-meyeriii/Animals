using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog {

        public bool IsSmall { get; set; } = false;

        public Boxer(string Name) : base(Name) {
            IsSmall = false;
            Muzzle = MuzzleType.Short;
        }



        public Boxer() {

        }
        // had to add the override to the method to get the specific dog vs just dog alone

        public override string GetTypeOfDog() {
            return "Boxer";

        }
    }
}

