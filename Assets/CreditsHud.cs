using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
public class CreditsHud : MonoBehaviour
{

	private int xpos = 350;
	private int ypos = 10;

	private GUIStyle guiStyle = new GUIStyle();
	
	void Start() {
	
	}

	void OnGUI() {
		int x = xpos+150;
		int y = ypos;

		guiStyle.normal.textColor = Color.green;
		guiStyle.fontSize = 70;
		GUI.Label(new Rect(x, y, 100, 20), "You Won!", guiStyle);

		x = xpos-25;
		y = y+200;
		GUI.Label(new Rect(x, y, 100, 20), "Remaining Time: "+SceneInfo.rem_time+"s", guiStyle);

		x = xpos;
		y = y+200;
		GUI.Label(new Rect(x, y, 100, 20), "Thanks for Playing!", guiStyle);

		x = xpos+180;
		y = y+150;
		guiStyle.fontSize = 20;
		GUI.Label(new Rect(x, y, 100, 20), "Prototype version 1.1.0.10", guiStyle);
	}

	void Update() {
	
	}
}
