using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menubutton : MonoBehaviour {

	private Button button;
	public string scenename;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button>();
		button.onClick.AddListener(OnClick);
	}
	void OnClick () {
		SceneManager.LoadScene(scenename);
	}
}
