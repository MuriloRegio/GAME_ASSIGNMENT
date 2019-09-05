using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
	Vector3 myPos;
	Transform myPlay;
	 
    // Start is called before the first frame update
    void Start()
    {
     	myPlay = GameObject.Find("Character").transform;
		
		myPos  = transform.position;
		myPos -= myPlay.position;
    }
    
	void Update()
	{
		// Vector3 pos = myPlay.position;
		// pos += myPos;
		// transform.position = pos;
	}
}
