using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC: MonoBehaviour {

    public string Name;
    public int Aggression;

    public int HP;
    public int Strength;
    public int Agility;
    public int Charisma;
    public int Dexterity;

    public string weaponName;
    public int weaponDamage;
    public bool romancable;


    GameObject player;

	// Use this for initialization
	void Start () {

        player = GameObject.Find("playerCharacter");
		
	}
	
	// Update is called once per frame
	void Update () {
    
		
	}


    
}
