using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour {

    //At the beginning of a script, we need to declare Variables - these are all the possible values that we'll need to call upon
    // or make use of throughout the script - they'll make more sense later on!

    public float moveSpeed = 2.0f;  //Defines the speed our animal moves at
    public int cooldown; //Defines the counter for the cooldown period between actions, to stop our animal making decisions too rapidly
    public Vector3 targetPos; //Contains the position that our animal will move to each time he decides to move
    public GameObject posMarker;
    GameObject tempPosMarker;
    public bool isResting; //Is our animal resting? This 'true or false' value contains the answer!

    //The following variables are for calculating the minimum and maximum area of the screen, so our animal doesn't move out of sight!
    public GameObject minXmaxY;
    public GameObject maxXminY;
    float minX, maxX, minY, maxY;

    public float Energy; //Important! This is our animals energy
    int energyModifier; //This will contain the modifier for our animals energy
    public Text energyCounter; //The actual in-game text object used to display our animal's energy
    public Text statusText; //The actual in-game text object used to display our animal's status

    public bool movementTriggered = false; //A true/false variable used to tell whether the animal is moving!

    public int decisionNumber;

    public GameObject food;
    public Vector3 foodtargetPos;

    public void Start()
    {
        Energy = 100;
        
        //These set the boundaries of the playing area, so the animal doesnt wander where they shouldn't
        minX = minXmaxY.transform.position.x;
        maxX = maxXminY.transform.position.x;
        maxY = minXmaxY.transform.position.y;
        minY = maxXminY.transform.position.y;
    }

    public void Update()
    {
        //If we're not resting, make sure the on-screen energy counter is updating to show the energy level
        if (isResting == false)
        {
            energyCounter.text = "Energy: " + Energy.ToString("F0");
        }

        //Check to make sure our animal isn't already in the middle of an action - he needs to have a chance to breathe between movements!
        if (cooldown <= 0)
        {

            //First, make sure our dinosaur isn't already moving.
            movementTriggered = false;
            gameObject.GetComponent<Animator>().SetBool("isWalking", false);
            GameObject.Destroy(tempPosMarker);

            //Making decisions

            if (Energy > 50)
            {
                //If energy is more than 50, add 20 to the value, making it more likely our animal will want to move
                energyModifier = 20;
            }
            else if (Energy < 50)
            {
                //If energy is less than 50, decrease 20 from the decision number, making it more likely our animal will want to rest
                energyModifier = -20;
            }

            //Randomise number
            decisionNumber = Random.Range(0, 100) + energyModifier;

            //Make decisions based on that number
            if (decisionNumber >= 0 && decisionNumber <= 75)
            {
                //If the number is between 0 and 75 - our animal will rest!
                targetPos = gameObject.transform.position;
                movementTriggered = false;
                isResting = true;
                cooldown = Random.Range(50, 300);
                statusText.text = "Status: Resting";
            }

            if (decisionNumber >= 76 && decisionNumber <= 100)
            {
                //However, if the number is between 76 and 100, our animal will move!
                isResting = false;

                statusText.text = "Status: Moving";

                //Set our target position to be a random position, between the bounds of the screen so he remains on camera!
                targetPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), gameObject.transform.position.z);

                if (tempPosMarker != null)
                {
                    Destroy(tempPosMarker);
                }
                tempPosMarker = Instantiate(posMarker);
                tempPosMarker.transform.position = targetPos;
                movementTriggered = true;
                cooldown = Random.Range(50, 300);
            }

        }


        //This 'if statement' checks to see whether our animal's movement has been triggered, and handles his actual movement!
        if (movementTriggered == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

            Vector3 diff = targetPos - transform.position;
            diff.Normalize();

            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

            gameObject.GetComponent<Animator>().SetBool("isWalking", true);

            Debug.Log("Distance from player to target is " + Vector3.Distance(targetPos, transform.position));

        }
        //This if statement will detect whether the animal is close to his targetposition - if he is, hes reached his destination and we have to
        // stop him moving!
        if (movementTriggered == true && Vector3.Distance(targetPos, transform.position) < 0.01f)
        {
            movementTriggered = false;
            gameObject.GetComponent<Animator>().SetBool("isWalking", false);
            GameObject.Destroy(tempPosMarker);

        }



        if (cooldown > 0)
        {
            cooldown --;
        }

        if (Energy >= 0 && movementTriggered == true)
        {
            //Energy -= Time.deltaTime/3
            Energy -= Time.deltaTime;
        }

        if (Energy > 100)
        {
            Energy = 100;
        }


        //Check to see whether the player has clicked
        if (Input.GetMouseButtonDown(0))
        {
            //Detect where the user has clicked and turn that into an on-screen location
            Vector3 VScreen = new Vector3();
            Vector3 VWold = new Vector3();
            VScreen.x = Input.mousePosition.x;
            VScreen.y = Input.mousePosition.y;
            VScreen.z = 10;
            VWold = Camera.main.ScreenToWorldPoint(VScreen);

            //Place food at the point of click
            GameObject foody = Instantiate(food);
            foody.transform.position = VWold;

        }



    }


    //This handles whether the animal can detect an object nearby
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Check if the object detected is food
        if (collision.tag == "Food")
        {
            //Set our new target position to be where the food is
            targetPos = collision.transform.position;
            movementTriggered = true;
        }
    }
}
