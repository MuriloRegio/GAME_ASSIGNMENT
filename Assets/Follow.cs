using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
	public float sensitivity = 1F;

	GameObject player;
	 
 //    // Start is called before the first frame update
    void Start()
    {
     	player = GameObject.Find("Character");
    }
    
	// void Update()
	// {
	// 	// Vector3 pos = myPlay.position;
	// 	// pos += myPos;
	// 	// transform.position = pos;
	// }


	void FixedUpdate ()
	{
		// float rotateHorizontal = Input.GetAxis ("Mouse X");
		// float rotateVertical = Input.GetAxis ("Mouse Y");
		// transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
		// transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player
	}
	
	public float speed = 3.5f;
     // private float X;
     // private float Y;
 
   //   void Update() {
   //       if(Input.GetMouseButton(0)) {
   //           // transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
			// float rotateHorizontal = Input.GetAxis ("Mouse X");
			// float rotateVertical = Input.GetAxis ("Mouse Y");
			// transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
   //           // X = transform.rotation.eulerAngles.x;
   //           // Y = transform.rotation.eulerAngles.y;
   //           // transform.rotation = Quaternion.Euler(X, Y, 0);
   //       }
     // }
}
