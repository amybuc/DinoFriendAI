using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour {

    public float moveSpeed = 2.0f;  // Units per second
    public int cooldown;
    public Vector3 targetPos;
    public GameObject posMarker;
    GameObject tempPosMarker;
    public bool isResting;

    public GameObject minXmaxY;
    public GameObject maxXminY;
    float minX, maxX, minY, maxY;

    public float Energy;
    int energyModifier;
    public Text energyCounter;
    public Text statusText;

    public bool movementTriggered = false;

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


        if (cooldown <= 0)
        {

            //First, make sure our dinosaur isn't already moving.
            movementTriggered = false;
            gameObject.GetComponent<Animator>().SetBool("isWalking", false);
            GameObject.Destroy(tempPosMarker);

            //Making decisions

            if (Energy > 50)
            {
                //If energy is more than 50, add 20 to the value
                energyModifier = 20;
            }
            else if (Energy < 50)
            {
                //If energy is less tahn 50, decrease 20 from the decision number
                energyModifier = -20;
            }

            //Randomise number
            decisionNumber = Random.Range(0, 100) + energyModifier;

            //Make decisions based on that number
            if (decisionNumber >= 0 && decisionNumber <= 75)
            {
                targetPos = gameObject.transform.position;
                movementTriggered = false;
                isResting = true;
                cooldown = Random.Range(50, 300);
                statusText.text = "Status: Resting";
            }

            if (decisionNumber >= 76 && decisionNumber <= 100)
            {
                isResting = false;

                statusText.text = "Status: Moving";

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
