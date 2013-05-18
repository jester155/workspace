using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary {
    public class Dice {
	    //.Publicly used object references
	    Random r = new Random(Environment.TickCount);

	    //.Fields parallel arrays to facilitate shorter coding as well as to check the selected dice against it's sides
	    private string[] diceName = { "d4" , "d6" , "d8" , "d10" , "d12" , "d20" };
	    private int[] diceSides = { 4 , 6 , 8 , 10 , 12 , 20 };
	    private List<string> selectedDice = new List<string>();
	    private int numberOfDice;

	    //.Constructors to set the dice from there or have no selected dice by default
	    public Dice() { }

	    //.SETS FOR ONLY ONE DIE --> CONSTRUCTOR
	    public Dice(String selectedDie) {
		    for(int i = 0 ; i < diceSides.Length ; i++)
			    if(this.diceName[i].Equals(selectedDie.ToLower())) {
				    this.selectedDice.Add(selectedDie.ToLower());
				    break;
			    }
	    }

	    //.Sets the number of dice to use as well as asks the user which dice to use CONSTRUCTOR
	    public Dice(int numberOfDice) {
		    this.numberOfDice = numberOfDice;
		    for(int i = 0 ; i < this.numberOfDice ; i++) {
			    string choice = Console.ReadLine(); //.------>Change this line of code to match whatever input you are using<------.//
			    for(int j = 0 ; j < this.diceName.Length ; j++)
				    if(this.diceName[j].Equals(choice.ToLower()))
					    this.selectedDice.Add(choice);
		    }
	    }

	    //.Gets and sets the number of dice to use
	    public int NumberOfDice {
		    get { return this.numberOfDice; }
		    set { this.numberOfDice = value; }
	    }

	    //.sets the selected Dice to the proper and needed die ONLY ONE DIE
	    public void setSelectedDice(String selectedDie) {
		    if(this.selectedDice.Contains(selectedDie) == true)
			    for(int i = 0 ; i < this.diceSides.Length ; i++)
				    if(this.diceName[i].Equals(selectedDie.ToLower())) {
					    this.selectedDice.Add(selectedDie.ToLower());
					    break;
				    }
	    }
	    
	    //.Use if the user needs to or wants to use more than one die
	    public void setMultipleDice() {
		    for(int i = 0 ; i < this.numberOfDice ; i++) {
			    String choice = Console.ReadLine(); //.------>Change this line of code to match whatever input you are using<------.//
			    for(int j = 0 ; j < this.diceName.Length ; j++)
				    if(this.diceName[j].Equals(choice))
					    this.selectedDice.Add(choice);
		    }
	    }

	    public String[] getSelectedDie() {
			this.selectedDice.Sort();
			String[] results = new String[this.selectedDice.Count];
			int i = 0;
			foreach(String item in this.selectedDice)
				results[i++] = item;
			return results;
	   }
	    //.Rolls the selected die
	    
	   public int[] rollDice() {
			this.selectedDice.Sort();
			int[] results = new int[this.selectedDice.Count]; 
			int counterForResults = 0;
			foreach(String item in this.selectedDice)
				for (int i = 0; i < this.diceSides.Length; i++) 
					if(item.ToLower().Equals(this.diceName[i]))
						results[counterForResults++] = r.Next(1 , this.diceSides[i]);
			return results;	
	    }

	   //.Removes all the dice from the selectedDie Array List field 
	   public void resetDice() {
			this.selectedDice.Clear();
	   }
    }
}
