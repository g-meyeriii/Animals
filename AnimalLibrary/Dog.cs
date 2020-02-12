using System;

namespace AnimalLibrary { //Can change the namespace to let the program use the dog constuctor
   
    public enum MuzzleType { Long, Short, Collapsed};//this is enumeration adding this new class created outside the class for a value must be referenced in the program by this name and the property MuzzleType.Long or {Long, Short, Collapsed}, 
    public enum BarkPitchType { Low, Medium, High};

    public class Dog {
        //Properties

        public bool LongTail { get; set; }
        public BarkPitchType BarkPitch { get; set; } //high,medium,low
        public MuzzleType Muzzle { get; set; } // long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;
        public string Name { get; set; }


        //Another
        public Dog(string Name) {
            if (Name == null) { 
                this.Name = "Fido";
              } else { this.Name = Name;}
            }
        //always add your own default constructor
        public Dog() {

        }

        //Methods  Added the virtual to the base class for this method to present something other that dog
        public virtual string GetTypeOfDog() {
            return "Dog";        
        }

    }
}
