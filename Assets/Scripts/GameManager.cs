using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public Text mainText;
	public GameObject finalPanel;
	// Use this for initialization
	void Start () {
		mainText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (FindObjectsOfType<Enemy> ().Length <= 0) {
			mainText.text = "You Win!";
			finalPanel.SetActive (true);
		}

		if (!FindObjectOfType<PlayerController>()) {
			mainText.text = "You Lose!";
			finalPanel.SetActive (true);
		}



	}

	public void RestartLevel(){
		SceneManager.LoadScene (0);
	}
}
