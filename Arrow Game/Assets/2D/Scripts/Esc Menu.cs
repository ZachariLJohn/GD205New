using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour {
	
	public string loadedLevelName;

	// Use this for initialization
	void Start () {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene(loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
