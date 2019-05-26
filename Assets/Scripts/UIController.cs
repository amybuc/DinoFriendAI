using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    //Global Variables to grab
    public GameObject gameController;

    //Variables as relating to the main menu
    public GameObject menuScreen;
    public GameObject menuCompanionList;
    public GameObject companionListObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeScreens(GameObject screentoClose, GameObject screentoOpen)
    {
        screentoClose.SetActive(false);
        screentoOpen.SetActive(true);
    }

    public void openPopupScreen(GameObject screenToOpen)
    {
        screenToOpen.SetActive(true);
    }

    public void closePopupScreen(GameObject screenToClose)
    {
        screenToClose.SetActive(false);
    }

    public void loadInGameMenu()
    {
        //A function to fill out the menu information when the user opens the in-game menu

        //First, fill the list of companions currently in party
        foreach (Companion companion in gameController.GetComponent<partyManager>().partyMembers)
        {
            GameObject partyCompanion = Instantiate(companionListObject);
            partyCompanion.transform.SetParent(menuCompanionList.transform);

            foreach(Transform childrenText in partyCompanion.transform )
            {
                Debug.Log("Child name is: " + childrenText.gameObject.name);

                if (childrenText.gameObject.name == "nameText")
                {
                    childrenText.GetComponent<Text>().text = companion.Name;
                }
                else if (childrenText.gameObject.name == "levelText")
                {
                    childrenText.GetComponent<Text>().text = companion.Level.ToString();
                }
                else if (childrenText.gameObject.name == "typeText")
                {
                    childrenText.GetComponent<Text>().text = companion.Class;
                }
            }

        }
    }

    public void loadNewCompanionScreen(GameObject screen)
    {
        /*Should find the companion art templates and run the gamecontroller's randomising companion
         * setup on them. Should also setup buttons to be able to add them to the party, also checking
         * player coins, etc.
         */

        //First, find all the companions and randomise a new companion for each one
        foreach (Transform child in screen.transform)
        {

        }



    }
}
