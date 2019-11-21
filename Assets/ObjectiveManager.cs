using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
	bool hasKey = false;

	GameObject player;
	GameObject door_light;
	Light dl;

    // Start is called before the first frame update
    void Start()
    {
    	door_light = GameObject.FindWithTag("DOOR_LIGHT");
        dl = door_light.GetComponent<Light>();
        player = player = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
    	float distance = Vector3.Distance(door_light.transform.position, player.transform.position);

    	dl.intensity = distance;

    	Debug.Log(dl.intensity);
    }

    void OnCollisionEnter (Collision col)
    {    	
        if (col.gameObject.CompareTag("Key")){
        	hasKey = true;
        	Destroy(col.gameObject, 0.1f);
        	Destroy(GameObject.FindWithTag("KEY_LIGHT"), 0.1f);
        	return;
        }
        if (col.gameObject.CompareTag("Door")){
        	if (!hasKey)
        		return;

        	Debug.Log("GAME OVER");
        	SceneManager.LoadScene("Credits");
        }
    }
}
