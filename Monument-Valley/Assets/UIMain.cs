using UnityEngine;
using System.Collections;

public class UIMain : MonoBehaviour {

	MapMaker myScenece;

	// Use this for initialization
	void Start () {
		myScenece = GameObject.Find ("MapMaker").GetComponent<MapMaker> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUI.Box(new Rect(10,10,100,180), "Scenes");
		
		if(GUI.Button(new Rect(20,40,80,20), "Scene 1")) {
			myScenece.Load (1);
		}
		 
	}
}
