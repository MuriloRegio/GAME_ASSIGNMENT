using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
public class Hud : MonoBehaviour
{
	public float rem_time = 30F;

	
	private int mod  =  2;
	private int xpos = 50;
	private int ypos = 10;

	private GUIStyle guiStyle = new GUIStyle();
	int last;

	void Start() {
		last = ((int) rem_time) + 1;
	}

	void OnGUI() {
		int time = (int) Mathf.Round(rem_time);

		int x = xpos;
		int y = ypos;

		if (time < last){
			x=600;
			y=5;
			guiStyle.fontSize *= mod;
		}

		last = time;

		if (time == 0){
			Time.timeScale = 0;
			guiStyle.fontSize *= mod;
		}


		GUI.Label(new Rect(x, y, 100, 20), ""+time, guiStyle);
	}

	void Update() {
		guiStyle.fontSize = 40;

		if (rem_time <= 0){
			mod = 4;
			return;
		}

		rem_time -= Time.deltaTime;

		guiStyle.normal.textColor = Color.green;
		mod = 2;
		
		if (rem_time < 15){
			guiStyle.normal.textColor = Color.yellow;
			mod = 3;
		}

		if (rem_time < 5){
			guiStyle.normal.textColor = Color.red;
			mod = 4;
		}
	}
}
