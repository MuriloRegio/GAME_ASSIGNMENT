using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
	public float speed = 20F;
	public float sensitivity = 1F;

	SpriteRenderer mySpriteRenderer;
	Vector3 myPos;
	Rigidbody rgd;


	Animator animator;
	Hud hud;

	// Start is called before the first frame update
	void Start()
	{
		rgd = GetComponent<Rigidbody>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();

		animator 	= GetComponent<Animator>();
		var camera  = GameObject.FindWithTag("MainCamera");
		hud 	 	= camera.GetComponent<Hud>();
	}

	// Update is called once per frame
	void Update()
	{
		if (hud.rem_time <= 2){
			// Debug.Log(hud.rem_time);
			animator.SetBool("isDead", true);
			return;
		}

		animator.SetBool("isAttacking", false);

		var front = Camera.main.transform.forward;
		var right = Camera.main.transform.right;

		var hor = Input.GetAxis("Horizontal");
		var ver = Input.GetAxis("Vertical");

		myPos = Vector3.zero;
		myPos+= front * speed * ver;
		myPos+= right * speed * hor;

		// if (ver < 0)
		// 	mySpriteRenderer.flipX = true;
		// if (ver > 0)
		// 	mySpriteRenderer.flipX = false;
		// if (hor < 0)
		// 	mySpriteRenderer.flipX = true;
		// if (hor > 0)
		// 	mySpriteRenderer.flipX = false;
		if (ver != 0)
			mySpriteRenderer.flipX = ver < 0;
		if (hor != 0)
			mySpriteRenderer.flipX = hor < 0;

		rgd.velocity = myPos * Time.timeScale;


		// if(Input.GetButton("Fire1")){
		// 	animator.SetBool("isAttacking", true);
		// 	Debug.Log("Y THO");
		// }

		// if(true) {
		if(Input.GetButton("Fire2")) {
			float rotateHorizontal = Input.GetAxis ("Mouse X");
			transform.RotateAround(transform.position, Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
		}
	}

    void OnCollisionEnter (Collision col)
    {
    	
    }
}
