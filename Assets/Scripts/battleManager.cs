using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class battleManager : MonoBehaviour {

    public partyManager partyManager;

    public Canvas battleModeCanvas;
    public GameObject battlePrepWindow;

    //Battle Prep Window Variables
    public GameObject partyListContent;
    public GameObject partyMemberButtonPrefab;

    //Battle Screen Variables
    public GameObject Companion01Art;
    public GameObject Companion02Art;
    public GameObject Companion03Art;

    public List<Companion> activeInBattle = new List<Companion>();

    NPC enemyNPC;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void openBattlePrepDialogue(NPC enemy)
    {
        //First, activate all necessary canvases
        battleModeCanvas.gameObject.SetActive(true);

        enemyNPC = enemy;

        foreach (Companion companion in partyManager.partyMembers)
        {
            Debug.Log("companion detected");
            GameObject partyMemberButton = Instantiate(partyMemberButtonPrefab);
            partyMemberButton.transform.SetParent(partyListContent.transform);

            partyMemberButton.GetComponentInChildren<Text>().text = companion.Name;
            partyMemberButton.GetComponent<companionSelectButton>().nameOfCompanion = companion.Name;
            partyMemberButton.transform.GetChild(1).gameObject.GetComponent<Image>().enabled=false;
            partyMemberButton.GetComponent<Button>().onClick.AddListener(addCompanionToBattleQueue);

        }

    }

    public void addCompanionToBattleQueue()
    {

        //EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().isActiveInBattle = !EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().isActiveInBattle;


        if (EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().isActiveInBattle == true)
        {
            EventSystem.current.currentSelectedGameObject.transform.GetChild(1).gameObject.GetComponent<Image>().enabled = false;

            List<Companion> companionsToRemove = new List<Companion>();


            foreach (Companion companion in activeInBattle)
            {
                if (companion.Name == EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().nameOfCompanion)
                {
                    companionsToRemove.Add(companion);
                }
            }

            Debug.Log("Companion about to be removed: " + companionsToRemove[0].Name);

            if (companionsToRemove.Count > 0)
            {
                foreach (Companion companion in companionsToRemove)
                {
                    activeInBattle.Remove(companion);
                    Debug.Log("Companion being removed in for loop: " + companion.Name);
                    Debug.Log("Companions in companions to remove: " + companionsToRemove.Count);
                }

                Debug.Log("Amount of companions active in battle: " + activeInBattle.Count);
                companionsToRemove.Clear();
            }

            EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().isActiveInBattle = false;
        }

        else if (EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().isActiveInBattle == false)
        {
            foreach (Companion companion in partyManager.partyMembers)
            {
                if (companion.Name == EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text)
                {
                    activeInBattle.Add(companion);
                    Debug.Log("Companion added to the active in battle list is: " + companion.Name);
                    EventSystem.current.currentSelectedGameObject.transform.GetChild(1).gameObject.GetComponent<Image>().enabled = true;
                }
            }

            EventSystem.current.currentSelectedGameObject.GetComponent<companionSelectButton>().isActiveInBattle = true;
        }
    }

    public void startBattle()
    {

        if (activeInBattle.Count == 0)
        {
            Debug.Log("No companions active in battle");
            return;
        }

        else
        {
            //At some point, gotta work out how and when to calculate HP loss and stat weighing. For now, just set things up
            //First, activate necessary canvases
            battlePrepWindow.SetActive(false);

            foreach (Companion companion in activeInBattle)
            {
                Debug.Log("Active Companion: " + companion.Name);
            }


            //Set up visuals
            if (activeInBattle.Count == 1)
            {
                Companion03Art.SetActive(false);
                Companion02Art.SetActive(false);
                Companion01Art.SetActive(true);
                Companion01Art.GetComponent<compArtHandler>().setUpCompanion(activeInBattle[0]);
            }
            if (activeInBattle.Count == 2)
            {
                Companion03Art.SetActive(false);
                Companion02Art.SetActive(true);
                Companion01Art.SetActive(true);
                Companion01Art.GetComponent<compArtHandler>().setUpCompanion(activeInBattle[0]);
                Companion02Art.GetComponent<compArtHandler>().setUpCompanion(activeInBattle[1]);
            }
            if (activeInBattle.Count == 3)
            {
                Companion03Art.SetActive(true);
                Companion02Art.SetActive(true);
                Companion03Art.SetActive(true);
                Companion01Art.GetComponent<compArtHandler>().setUpCompanion(activeInBattle[0]);
                Companion02Art.GetComponent<compArtHandler>().setUpCompanion(activeInBattle[1]);
                Companion03Art.GetComponent<compArtHandler>().setUpCompanion(activeInBattle[2]);
            }

        }




        //Next, calculate damage etc from all parties and compare it with 



    }
}
