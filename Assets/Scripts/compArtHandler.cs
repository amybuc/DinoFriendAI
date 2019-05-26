using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compArtHandler : MonoBehaviour {

    public StringStorage stringStorage;

	// Use this for initialization
	void Awake () {

        stringStorage = GameObject.Find("GameController").GetComponent<StringStorage>();

        if (stringStorage != null)
        {
            Debug.Log("stringStorage found");
            if (stringStorage.compArt_bod_database != null)
            {
                Debug.Log("String array within storage found");
                Debug.Log("" + stringStorage.compArt_bod_database[0]);
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setUpCompanion(Companion companion)
    {
        //Each Companion has a string reference to their appearance - split this into readable applicable chunks
        string[] splitArtRefs;
        splitArtRefs = companion.appearance.Split('/');


        //TURN ALL THE SPLIT INTS INTO REFERENCES TO THE ARRAYS OF IMAGE PATHS - ASSIGN THE RIGHT IMAGE TO THE RIGHT IMAGE OBJECT

        foreach (Transform child in gameObject.transform)
        {
            //Debug.Log("name o child " + child.name);
            //Debug.Log("ref " + splitArtRefs[0]);

            if (child.name == "compImg_base")
            {
                Debug.Log("" + splitArtRefs[0]);
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_bod_database[int.Parse(splitArtRefs[0])]);
            }

            if (child.name == "compImg_shirt")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_shirt_database[int.Parse(splitArtRefs[1])]);
            }
            if (child.name == "compImg_hair")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_hair_database[int.Parse(splitArtRefs[2])]);
            }
            if (child.name == "compImg_pant")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_pant_database[int.Parse(splitArtRefs[3])]);
            }
            if (child.name == "compImg_eyes")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_eyes_database[int.Parse(splitArtRefs[4])]);
            }
            if (child.name == "compImg_mouth")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_mouth_database[int.Parse(splitArtRefs[5])]);
            }
            if (child.name == "compImg_extra")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_extra_database[int.Parse(splitArtRefs[6])]);
            }



        }




    }

    public void setUpCompanionArt(Companion companion, GameObject artParent)
    {
        //Each Companion has a string reference to their appearance - split this into readable applicable chunks
        string[] splitArtRefs;
        splitArtRefs = companion.appearance.Split('/');


        //TURN ALL THE SPLIT INTS INTO REFERENCES TO THE ARRAYS OF IMAGE PATHS - ASSIGN THE RIGHT IMAGE TO THE RIGHT IMAGE OBJECT

        foreach (Transform child in gameObject.transform)
        {
            //Debug.Log("name o child " + child.name);
            //Debug.Log("ref " + splitArtRefs[0]);

            if (child.name == "compImg_base")
            {
                Debug.Log("" + splitArtRefs[0]);
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_bod_database[int.Parse(splitArtRefs[0])]);
            }

            if (child.name == "compImg_shirt")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_shirt_database[int.Parse(splitArtRefs[1])]);
            }
            if (child.name == "compImg_hair")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_hair_database[int.Parse(splitArtRefs[2])]);
            }
            if (child.name == "compImg_pant")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_pant_database[int.Parse(splitArtRefs[3])]);
            }
            if (child.name == "compImg_eyes")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_eyes_database[int.Parse(splitArtRefs[4])]);
            }
            if (child.name == "compImg_mouth")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_mouth_database[int.Parse(splitArtRefs[5])]);
            }
            if (child.name == "compImg_extra")
            {
                child.GetComponent<Image>().sprite = Resources.Load<Sprite>(stringStorage.compArt_extra_database[int.Parse(splitArtRefs[6])]);
            }



        }




    }
}
