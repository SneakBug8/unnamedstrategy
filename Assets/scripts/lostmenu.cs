using UnityEngine;
using UnityEngine.UI;

public class lostmenu : MonoBehaviour {
	public Text losttext;
	public Text newgame;

	// Use this for initialization
	void Start () {
		losttext.text=LangController.Global.GetString("lost");
		newgame.text=LangController.Global.GetString("newgame");
	}
}
