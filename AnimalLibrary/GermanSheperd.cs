using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    //Below is an example of inheritence, all the things of dog classs, and will have more for the g.sheperd class
    public class GermanSheperd : Dog {// This statement tells use what it is inheriting : Dog (base class) g.sheperd is derived class.

        public bool BigDog { get; set; } = true;
        //This is a use of both two constuctors one from base and the other from the derived constructors 
        public GermanSheperd(string Name): base(Name) {
            this.LongTail = true;

        }
        public GermanSheperd() {
            this.Muzzle = MuzzleType.Long;
        }
        // had to add the override to the method to get the specific dog vs just dog alone
            public override  string GetTypeOfDog() {
                return "German Sheperd";

            }
    }
}
