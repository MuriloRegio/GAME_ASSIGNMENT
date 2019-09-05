using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
	KeyCode [] myKeys = new KeyCode[4];
	Vector3 myPos;
	float speed = 1.5F;

    // Start is called before the first frame update
    void Start()
    {
		myKeys[0] = KeyCode.W;
		myKeys[1] = KeyCode.A;
		myKeys[2] = KeyCode.S;
		myKeys[3] = KeyCode.D;
    }

    // Update is called once per frame
    void Update()
    {
    	myPos = transform.position;
		foreach (KeyCode key in myKeys){
			if (Input.GetKeyDown(key)){
				switch (key)
				{
					case KeyCode.W: 
						Debug.Log("W!");
						myPos.z+= speed;
						break;
					case KeyCode.S:
						Debug.Log("S!");
						myPos.z-= speed;
						break;
					case KeyCode.A:
						Debug.Log("A!");
						myPos.x-= speed;
						break;
					case KeyCode.D:
						Debug.Log("D!");
						myPos.x+= speed;
						break;
				}
			}
		}
		transform.position = myPos;
    }
}
