using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetAxis("Mouse X")<0){
			//Code for action on mouse moving left
			Debug.Log("Mouse moved left");
		}
		if(Input.GetAxis("Mouse X")>0){
			//Code for action on mouse moving right
			Debug.Log("Mouse moved right");
		}
		if(Input.GetAxis("Mouse Y")<0){
			//Code for action on mouse moving left
			Debug.Log("Mouse moved down");
		}
		if(Input.GetAxis("Mouse Y")>0){
			//Code for action on mouse moving right
			Debug.Log("Mouse moved up");
		}
    }
}
