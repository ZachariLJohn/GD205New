using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;

	public TextAsset textfile;
	public string[] textlines;

	public int currentLine;
	public int endline;

	public PlatformerCharacter2D player;

	// Use this for initialization
	void Start () {
		 
		player = FindObjectOfType<PlatformerCharacter2D> ();

		if (textfile != null) 
		{

			textlines = (textfile.text.Split ('\n'));
		}
		if (endline == 0) 
		{
			endline = textlines.Length - 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		theText.text = textlines [currentLine];

		if (Input.GetKeyDown (KeyCode.Mouse0))
		{
			currentLine += 1;
		}

		if (currentLine > endline)
		{
			textBox.SetActive (false);
		}
	}
}
