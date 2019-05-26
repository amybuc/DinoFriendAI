using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour {


    public GameObject player;
    public Text animalName;
    public InputField inputField;
    public GameObject UI;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onGameStart()
    {
        string charName = inputField.text;
        animalName.text = charName;

        UI.SetActive(false);
        player.SetActive(true);
    }
}
