using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class partyManager : MonoBehaviour {

    public List<Companion> partyMembers = new List<Companion>();

    public Companion testCompanion;
    public Companion testCompanion2;

    StringStorage stringStorage;

    public GameObject randomCompanionArt;
    public Text compName, compSurname, compStrength, compAgility, compCharisma, compDexterity;

    //partyMembers is the list of companions in the party

    private void Awake()
    {
        stringStorage = GetComponent<StringStorage>();
    }

    // Use this for initialization
    void Start () {
    
        //For the sake of debugging, adding a companion to the list:

        testCompanion = new Companion();
        testCompanion.Name = "Debugger";
        testCompanion.Surname = "Debuggson";
        testCompanion.Level = 2;
        testCompanion.Class = "Fighter";
        testCompanion.HP = 20;
        testCompanion.EP = 50;
        testCompanion.Morale = 75;
        testCompanion.Strength = 3;
        testCompanion.Agility = 1;
        testCompanion.Charisma = 2;
        testCompanion.Dexterity = 4;
        testCompanion.isExtroverted = true;
        testCompanion.weaponType = "Longsword";
        testCompanion.weaponDamage = 5;
        testCompanion.appearance = "0/0/0/0/0/0/0";
        partyMembers.Add(testCompanion);

        testCompanion2 = new Companion();
        testCompanion2.Name = "Debuggula";
        testCompanion2.Surname = "Debugginator";
        testCompanion2.Level = 1;
        testCompanion2.Class = "Ranger";
        testCompanion2.HP = 15;
        testCompanion2.EP = 40;
        testCompanion2.Morale = 60;
        testCompanion2.Strength = 1;
        testCompanion2.Agility = 3;
        testCompanion2.Charisma = 3;
        testCompanion2.Dexterity = 4;
        testCompanion2.isExtroverted = false;
        testCompanion2.weaponType = "Bow";
        testCompanion2.weaponDamage = 4;
        testCompanion2.appearance = "1/1/1/1/1/1/1";
        partyMembers.Add(testCompanion2);




        Debug.Log("Name of companion #2 is " + partyMembers[1].Name + " " + partyMembers[1].Surname);



	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Companion generateRandomCompanion(int level)
    {
        Companion companion = new Companion();
        companion.Name = stringStorage.firstNameList[Random.Range(0, stringStorage.firstNameList.Length)];
        companion.Surname = stringStorage.surnameList[Random.Range(0, stringStorage.surnameList.Length)];
        companion.Level = level;
        companion.Strength = Random.Range(1, 4);
        companion.Agility = Random.Range(1, 4);
        companion.Charisma = Random.Range(1, 4);
        companion.Dexterity = Random.Range(1, 4);
        companion.appearance = "" + (Random.Range(0, stringStorage.compArt_bod_database.Length) +
                                     "/" + (Random.Range(0, stringStorage.compArt_shirt_database.Length)) +
                                     "/" + (Random.Range(0, stringStorage.compArt_hair_database.Length)) +
                                     "/" + (Random.Range(0, stringStorage.compArt_pant_database.Length)) +
                                     "/" + (Random.Range(0, stringStorage.compArt_eyes_database.Length)) +
                                     "/" + (Random.Range(0, stringStorage.compArt_mouth_database.Length)) +
                                     "/" + (Random.Range(0, stringStorage.compArt_extra_database.Length)));
        Debug.Log("RANGE: " + stringStorage.compArt_hair_database.Length);
        return companion;
    }

    public void GenerateRandomCompanionTestaroo(GameObject artObject)
    {
        Companion generatedCompanion = generateRandomCompanion(Random.Range(1, 5));
        artObject.GetComponent<compArtHandler>().setUpCompanion(generatedCompanion);

        foreach (Transform child in artObject.transform)
        {
            if (child.name == "txt_firstName")
            {
                child.GetComponent<Text>().text = generatedCompanion.Name;
            }
            if (child.name == "txt_surName")
            {
                child.GetComponent<Text>().text = generatedCompanion.Surname;
            }
            if (child.name == "txt_strength")
            {
                child.GetComponent<Text>().text = "STR :: " + generatedCompanion.Strength.ToString();
            }
            if (child.name == "txt_agility")
            {
                child.GetComponent<Text>().text = "AGI :: " + generatedCompanion.Agility.ToString();
            }
            if (child.name == "txt_charisma")
            {
                child.GetComponent<Text>().text = "CHA :: " + generatedCompanion.Charisma.ToString();
            }
            if (child.name == "txt_dexterity")
            {
                child.GetComponent<Text>().text = "DEX :: " + generatedCompanion.Dexterity.ToString();
            }
            if (child.name == "txt_class")
            {
                child.GetComponent<Text>().text = "Class :: " + generatedCompanion.Class;
            }

        }

        /*name.text = generatedCompanion.Name;
        surname.text = generatedCompanion.Surname;
        strength.text = "STR :: " + generatedCompanion.Strength;
        agility.text = "AGI :: " + generatedCompanion.Agility;
        charisma.text = "CHA :: " + generatedCompanion.Charisma;
        dexterity.text = "DEX :: " + generatedCompanion.Dexterity;
        charaClass.text = "Class :: " + generatedCompanion.Class;
        */
    }
}
