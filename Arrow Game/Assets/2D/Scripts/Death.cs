using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	public GameObject player;

		void OnCollisionEnter(Collision col)
		{
			if (col.gameObject.tag == "Death")
			{
				SceneManager.LoadScene("Level 1");
			}
		}
	}
