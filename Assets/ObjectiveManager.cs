using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
	bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter (Collision col)
    {    	
        if (col.gameObject.CompareTag("Key")){
        	hasKey = true;
        	Destroy(col.gameObject, 0.1f);
        	return;
        }
        if (col.gameObject.CompareTag("Door")){
        	if (!hasKey)
        		return;

        	Debug.Log("GAME OVER");
        }
    }
}
