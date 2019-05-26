using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class townData : MonoBehaviour {

    public string townName;
    public string alignment;
    public int relationshipToPlayer;
    public string welcomeMessageGood;
    public string welcomeMessageBad;

    [HideInInspector]
    public string partyMemberDisliked;
    [HideInInspector]
    public string renownHigh;
    [HideInInspector]
    public string notorietyHigh;



    // Use this for initialization
    void Start () {

        partyMemberDisliked = "One of your lot isn't welcome here. The rest of you should just leave as well.";
        renownHigh = "I've heard of you! You're that adventurer!";
        notorietyHigh = "We don't harbour criminals here. You'd best be on your way.";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
