using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Somethings being fucking detected");

        if (other.tag == "Player")
        {
            Debug.Log("distance is " + Vector3.Distance(gameObject.transform.position, other.transform.position));
            if (Vector3.Distance(gameObject.transform.position, other.transform.position) <= 1.5)
            {
                Debug.Log("Collido");
                other.GetComponent<playerMovement>().Energy = other.GetComponent<playerMovement>().Energy + 25;
                GameObject.Destroy(gameObject);
            }

        }
    }
}
