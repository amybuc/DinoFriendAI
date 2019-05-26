using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion {

    public string Name;
    public string Surname;
    public int Level;
    public string Class;
    public int HP;
    public int EP;
    public int Morale; //0-100
    public int Strength;
    public int Agility;
    public int Charisma;
    public int Dexterity;
    public bool isExtroverted;
    public string weaponType;
    public int weaponDamage; //Will change as weapon changes
    public string[] relationships; //Gotta work out how to do this ://

    public string appearance; /* A sequence of 7 Numbers
                                    0 - Defines Body
                                    1 - Shirt
                                    2 - Hair
                                    3 - Pant
                                    4 - Eye
                                    5 - Mouth
                                    6 - Extra


*/



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
