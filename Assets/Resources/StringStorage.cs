using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringStorage : MonoBehaviour
{

    #region FIRST NAME LIST
    public string[] firstNameList = new string[]{

        "Riek",
        "Samgo",
        "Niefor",
        "Eleram",
        "Yazma",
        "Ikiro",
        "Natura",
        "Ilfo",
        "Nat",
        "Sam",
        "Reego",
        "Moratz",
        "Iniyo",
        "Mahare",
        "Fief",
        "Ryan",
        "Taam",
        "Niro",
        "Kuratz",
        "Jia",
        "Turana",
        "Ava",
        "Altair",
        "Alshain",
        "Minaro",
        "Bullhorn",
        "Hart",
        "Keiro",
        "Morthing",
        "Hali",
        "Farrow",
        "Fallow",
        "Mortimer",
        "Beneir",
        "Alasko",
        "Wooma",
        "Shurika",
        "Cesar",
        "Forrow",
        "Itiyo",
        "Alayin",
        "Gruish",
        "Muro",
        "Cinnar",
        "Cinnamon",
        "Boris",
        "Una",
        "Shiko",
        "Gora",
        "Maelorn",
        "Raen",
        "Hurika",
        "Lyet",
        "Mycha",
        "Cass",
        "Cassius",
        "Lena",
        "Xed",
        "Ilrania",
        "Rordan",
        "Kanna"

    };

    #endregion

    #region SURNAME LIST
    public string[] surnameList = new string[]{

        "Hartwrencher",
        "Fiefmorner",
        "Morningstar",
        "Morganleaf",
        "Hallower",
        "Loggerman",
        "Bookreader",
        "Firestoker",
        "Earthdweller",
        "Nightwatcher",
        "Bowhunter",
        "Sharptooth",
        "Whitewater",
        "Lightwatcher",
        "Cloudshooter",
        "Timeherder",
        "Littlehands",
        "Eartheyes",
        "Cloudeyes",
        "Strongfoot",
        "Strongarm",
        "Wrencaller",
        "Robinherder",
        "Huntmaster",
        "Longwhisper",
        "Shortarm",
        "Birchdweller",
        "Hellhunter",
        "Mightchaser",
        "Lightdawn",
        "Pridesun",
        "Hammerfist",
        "Longshadow",
        "Silverwright",
        "Goldsmith",
        "Longdawn",
        "Longnose",
        "Heartsmith",
        "Brightnose",
        "Willowsight",
        "Oaklegs",
        "Balderdash"


    };

    #endregion

    #region INTROVERT MORALE DIALOGUE (0-15)
    public string[] introvertMoraleCritical = new string[]
    {
        "God it's a miserable, miserable world",
        "Don't talk to me",
        "Cut it out",
        "I can barely look at you",
        "I'm THIS close to beating up this whole god damn party",
        "You have no idea how to do anything",
        "Don't mind me, just thinking about all the other parties of adventurers I'd rather be with"
    };
    #endregion

    #region INTROVERT MORALE DIALOGUE (16-50)
    public string[] introvertMoraleLow = new string[]
    {
        "I've been better, I've been worse.",
        "Oh, were you talking to me? Hm",
        "Honestly? A bit bored",
        "I think our luck will change, there's a good wind blowing",
        "I think things are going just fine",
        "Adventurers fall on hard luck just as often as good luck. It passes."

    };
    #endregion

    #region INTROVERT MORALE DIALOGUE (51-75)
    public string[] introvertMoraleGood = new string[]
    {
        "My belly's full and my sword is sharp - things are good!",
        "Where to next, questmaster?",
        "Life is good - sometimes that's all we can ask",
        "I think as a questmaster, you're not half bad",
        "Point me to the next marauder, boss!"



    };
    #endregion

    #region INTROVERT MORALE DIALOGUE (76-100)
    public string[] introvertMoraleGreat = new string[]
    {
        "It's been a long time since i've travelled this happy, questmaster!",
        "Me? I'm happy as a clam, Questmaster."

    };
    #endregion

    #region INTROVERT INTRO DIALOGUE
    public string[] introvertIntro = new string[]
    {
        "I get the job done and I do the job well. What more can you ask of me?",
        "Leave me be to do my work, and you won't be disappointed",
        "I'll go where you lead, Questmaster",
        "I'm good at what I do. Need I say more?",
        "I don't like unnecessary chatter - are you going to hire me or not?",
        "You seem like you could hold down a group of adventurers - take me on?",
        "I'm itching to get back into the wilds, have me onboard?",
        "I'll watch your back, Questmaster. That's a promise",
        "I think you and I will get along. Let's see if I'm right, shall we?"

    };
    #endregion

    #region EXTROVERT INTRO DIALOGUE
    public string[] extrovertIntro = new string[]
    {
        "I'm the strongest mercenary in the west, you'd be a fool to pass on me!",
        "Oh, you've not heard of me? Strange, I'm a celebrity round these parts",
        "Point me in the direction of some heads to smash in, Questmaster",
        "You look a little scrawny, but you seem the type to keep their companions well fed",
        "Help me get out of this town, Questmaster. I have a thirst for the battlefield",
        "Well? You hiring me or not, I don't have all day",
        "I can make friends with just about anyone - that's a promise",
        "Enough talk, I want to kill things!"

    };
    #endregion

    #region HIGH RELATIONSHIP WITH PLAYER DIALOGUE
    public string[] hiRelwPlayer = new string[]
    {
        "If you need anything, you need only call",
        "I am with you, Questmaster - no matter what",
        "There is something different about you today - I like it.",
        "What is our heading, my dear?",
        "I would fight a million battles for you, Questmaster"

    };
    #endregion


    /*
    //FURTHER LISTS:

    - Social encounters dialogue, or at least ideas
        - Both internal and external dialogue - at least 100 possible events.
    - Combat encounters dialogue



    */





    #region COMPANION ART STRINGS;



    
    public string[] compArt_bod_database = new string[]{

    "companionArt/companionArtComp__0035_Base_m",
    "companionArt/companionArtComp__0034_Base_f"

    };


    //public List<string> compArt_bod_database;

    public string[] compArt_shirt_database = new string[]{

        "companionArt/companionArtComp__0033_Shirt_1",
        "companionArt/companionArtComp__0032_Shirt_2",
        "companionArt/companionArtComp__0031_Shirt_3",
        "companionArt/companionArtComp__0030_Shirt_4",
        "companionArt/companionArtComp__0029_Shirt_5",
        "companionArt/companionArtComp__0029_Shirt_6",
        "companionArt/companionArtComp__0029_Shirt_7"

    };

    public string[] compArt_hair_database = new string[]{

        "companionArt/companionArtComp__0028_Hair_1",
        "companionArt/companionArtComp__0027_Hair_2",
        "companionArt/companionArtComp__0026_Hair_3",
        "companionArt/companionArtComp__0025_Hair_4",
        "companionArt/companionArtComp__0024_Hair_5",
        "companionArt/companionArtComp__0023_Hair_6",
        "companionArt/companionArtComp__0022_Hair_7",
        "companionArt/companionArtComp__0022_Hair_8",
        "companionArt/companionArtComp__0022_Hair_9",
        "companionArt/companionArtComp__0022_Hair_10"

    };

    public string[] compArt_pant_database = new string[]{

        "companionArt/companionArtComp__0021_Pant_1",
        "companionArt/companionArtComp__0020_Pant_2",
        "companionArt/companionArtComp__0019_Pant_3",
        "companionArt/companionArtComp__0018_Pant_4",
        "companionArt/companionArtComp__0017_Pant_5",
        "companionArt/companionArtComp__0017_Pant_6",
        "companionArt/companionArtComp__0017_Pant_7"

    };

    public string[] compArt_eyes_database = new string[]{

        "companionArt/companionArtComp__0016_Eyes_1",
        "companionArt/companionArtComp__0015_Eyes_2",
        "companionArt/companionArtComp__0014_Eyes_3",
        "companionArt/companionArtComp__0013_Eyes_4",
        "companionArt/companionArtComp__0012_Eyes_5",
        "companionArt/companionArtComp__0011_Eyes_7"

    };

    public string[] compArt_mouth_database = new string[]{

        "companionArt/companionArtComp__0010_Mouth_1",
        "companionArt/companionArtComp__0009_Mouth_2",
        "companionArt/companionArtComp__0008_Mouth_3",
        "companionArt/companionArtComp__0007_Mouth_4",
        "companionArt/companionArtComp__0006_Mouth_5",
        "companionArt/companionArtComp__0005_Mouth_6",
        "companionArt/companionArtComp__0004_Mouth_7"

    };

    public string[] compArt_extra_database = new string[]{

        "companionArt/companionArtComp__0003_Extra_1",
        "companionArt/companionArtComp__0002_Extra_2",
        "companionArt/companionArtComp__0001_Extra_3",
        "companionArt/companionArtComp__0000_Extra_4"

    };

    #endregion


    public List<NPC> npcDatabase = new List<NPC>();




    // Use this for initialization
    void Start () {

        //Load up the npc Database

        NPC goblin = new NPC();
        goblin.Name = "Goblin";
        goblin.Aggression = 9;
        goblin.HP = 30;
        goblin.Strength = 4;
        goblin.Agility = 5;
        goblin.Charisma = 0;
        goblin.Dexterity = 2;
        goblin.weaponName = "Club";
        goblin.weaponDamage = 3;
        goblin.romancable = false;
        npcDatabase.Add(goblin);






    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
