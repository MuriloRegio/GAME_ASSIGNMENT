using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavioralManager : MonoBehaviour
{
	Animator animator;
	Hud hud;
	bool isColliding = false;

	Collider collider;

	// Start is called before the first frame update
	void Start()
	{
		animator 	= GetComponent<Animator>();
		var camera  = GameObject.FindWithTag("MainCamera");
		hud 		= camera.GetComponent<Hud>();
		collider 	= GetComponent<Collider>();
	}

	// Update is called once per frame
	void Update()
	{
		if (isColliding){
			hud.rem_time -= 5*Time.deltaTime;
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("Player"))
		{
			animator.SetBool("isColliding", true);
			isColliding = true;
		}else {
			Debug.Log(collider);
    		Physics.IgnoreCollision(col.collider, collider);
        }
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.CompareTag("Player"))
		{
			animator.SetBool("isColliding", false);
			isColliding = false;
		}
	}
}
