using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public static int score=0;
	public void OnGUI(){
		GUI.Button (new Rect (400, 20, 80, 30), "分数" + score);
	}
	// Use this for initialization
	void Start () {
		disk = DiskFactory.getDisk ();
		if (disk.onClick ()) {
			addScore ();
			free (disk);
		}
	}
	void addScore(){
		score++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
