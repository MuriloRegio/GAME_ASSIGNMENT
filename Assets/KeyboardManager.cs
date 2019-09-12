using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
	public float speed = 20F;
	public float sensitivity = 1F;

	SpriteRenderer mySpriteRenderer;
	KeyCode [] myKeys = new KeyCode[4];
	Vector3 myPos;
	Rigidbody rgd;

	// Start is called before the first frame update
	void Start()
	{
		myKeys[0] = KeyCode.W;
		myKeys[1] = KeyCode.A;
		myKeys[2] = KeyCode.S;
		myKeys[3] = KeyCode.D;

		rgd = GetComponent<Rigidbody>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		// rgd.velocity = Vector3.zero;
		var front = Camera.main.transform.forward;
		var right = Camera.main.transform.right;

		myPos = Vector3.zero;
		foreach (KeyCode key in myKeys){
			if (Input.GetKey(key)){
				switch (key)
				{
					case KeyCode.W: 
						// Debug.Log("W!");
						myPos+= front * speed;
						mySpriteRenderer.flipX = false;
						break;
					case KeyCode.S:
						// Debug.Log("S!");
						myPos+= front * speed * -1;
						mySpriteRenderer.flipX = true;
						break;
					case KeyCode.A:
						// Debug.Log("A!");
						myPos+= right * speed * -1;
						mySpriteRenderer.flipX = true;
						break;
					case KeyCode.D:
						// Debug.Log("D!");
						myPos+= right * speed;
						mySpriteRenderer.flipX = false;
						break;
				}
			}
		}
		rgd.velocity = myPos;
		// rgd.velocity = Vector3.zero;
		// transform.position = myPos;


		if(Input.GetMouseButton(1)) {
			float rotateHorizontal = Input.GetAxis ("Mouse X");
			float rotateVertical = Input.GetAxis ("Mouse Y");
			transform.RotateAround(transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
		}
	}

    void OnCollisionEnter (Collision col)
    {
    	// Debug.Log("Hit");
    }
}
