using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour {

	public Text NewGame;
	public Text Credits;
	void Start () {
		NewGame.text=LangController.Global.GetString("newgame");
		Credits.text=LangController.Global.GetString("credits");
	}
}
