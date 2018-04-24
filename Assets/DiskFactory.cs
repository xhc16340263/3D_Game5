using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskFactory : MonoBehaviour {

	public static GameObject gameObject;
	public DiskFactory instance;
	public List<GameObject> use;
	public GameObject prefab;
	public GameObject getDisk(){
		if (use.Count == 0) {
			gameObject = GameObject.Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity)as GameObject;
			gameObject.transform.Rotate (60f, 0, 0);
			return gameObject;
		} else
			return use [0];
	}
	public void free(GameObject obj){
		use.Add (obj);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
