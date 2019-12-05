using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navi : MonoBehaviour
{
	private Transform targetSpot; 
	private GameObject player;
	private float moveSpeed = 0.5f;

	void Start() {
		targetSpot = GameObject.FindWithTag("Key").transform;
		player = GameObject.FindWithTag("Player");
	}


	void Update() { 
		try{
			var nothing = targetSpot.position;
		}catch (Exception e){
			targetSpot = GameObject.FindWithTag("Door").transform;
		}


		// Debug.Log(Vector3.Distance(transform.position, player.transform.position));
		// Debug.Log(Vector3.Distance(transform.position, player.transform.position));
		if (Vector3.Distance(transform.position, player.transform.position) < 3){
			transform.position = Vector3.Lerp(transform.position, targetSpot.position, Time.deltaTime * moveSpeed); 
		}else{
			transform.position = Vector3.Lerp(transform.position, targetSpot.position, Time.deltaTime * moveSpeed); 
			transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * moveSpeed * 20); 
		}
	}
}
