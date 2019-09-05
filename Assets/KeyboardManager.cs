using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
	public float speed = 20F;


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
	}

	// Update is called once per frame
	void Update()
	{
		// rgd.velocity = Vector3.zero;
		myPos = Vector3.zero;
		foreach (KeyCode key in myKeys){
			if (Input.GetKey(key)){
				switch (key)
				{
					case KeyCode.W: 
						// Debug.Log("W!");
						myPos.z+= speed;
						break;
					case KeyCode.S:
						// Debug.Log("S!");
						myPos.z-= speed;
						break;
					case KeyCode.A:
						// Debug.Log("A!");
						myPos.x-= speed;
						break;
					case KeyCode.D:
						// Debug.Log("D!");
						myPos.x+= speed;
						break;
				}
			}
		}
		rgd.velocity = myPos;
		// rgd.velocity = Vector3.zero;
		// transform.position = myPos;
	}

    void OnCollisionEnter (Collision col)
    {
    	// Debug.Log("Hit");
    }
}
