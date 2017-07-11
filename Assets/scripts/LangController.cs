using System.Xml;
using UnityEngine;

public class LangController : MonoBehaviour {

	public static LangController Global;

	// Use this for initialization
	void Awake () {
		Global = this;
		DontDestroyOnLoad(Global);
	}
	public string GetString(string node) {
        XmlDocument xDoc = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("lang", typeof(TextAsset));
 		xDoc.LoadXml ( textAsset.text );
        XmlNode xRoot = xDoc.FirstChild;
		return xRoot[node].InnerText;
	}
}
