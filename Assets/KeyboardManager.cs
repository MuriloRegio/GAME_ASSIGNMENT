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

	// Start is called before the first frame update
	void Start()
	{
		rgd = GetComponent<Rigidbody>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		var front = Camera.main.transform.forward;
		var right = Camera.main.transform.right;

		var hor = Input.GetAxis("Horizontal");
		var ver = Input.GetAxis("Vertical");

		myPos = Vector3.zero;
		myPos+= front * speed * ver;
		myPos+= right * speed * hor;

		if (ver < 0)
			mySpriteRenderer.flipX = true;
		if (ver > 0)
			mySpriteRenderer.flipX = false;
		if (hor < 0)
			mySpriteRenderer.flipX = true;
		if (hor > 0)
			mySpriteRenderer.flipX = false;

		rgd.velocity = myPos * Time.timeScale;


		if(Input.GetButton("Fire2")) {
			float rotateHorizontal = Input.GetAxis ("Mouse X");
			float rotateVertical = Input.GetAxis ("Mouse Y");
			transform.RotateAround(transform.position, Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
		}
	}

    void OnCollisionEnter (Collision col)
    {
    	// Debug.Log("Hit");
    }
}
