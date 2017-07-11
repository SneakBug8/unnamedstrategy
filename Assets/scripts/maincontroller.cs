using System.Xml;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class maincontroller : MonoBehaviour {
	public Slider ChurchSlider;
	public Slider ArmySlider;
	public Slider PeopleSlider;
	public Slider EconomicsSlider;
	public Button Button0;
	public Button Button1;
	public Text text;

	public Text PointsText;

	public Relations relations;
	public Question[] questions;
	private Question question;
	private int questionnum;
	public int Points;

	public Text buttonyestext;
	public Text buttonnotext;

	// Use this for initialization
	void Start () {
		Questions.Global.Init();

		questions = Questions.Global.list;
		
		Destroy(Questions.Global);

		relations = new Relations(0,0,0,0);

		Button0.onClick.AddListener(delegate{onClick(true);});
		Button1.onClick.AddListener(delegate{onClick(false);});

		ChooseNewQuestion();

		buttonyestext.text=LangController.Global.GetString("yes");
		buttonnotext.text=LangController.Global.GetString("no");
	}

	void onClick(bool result) {
		/// Event, called if player clicked any of buttons
		Relations changes;
		if (result) {
			changes = question.changes;
		}
		else {
			changes = question.changes.Invert();
		}

		Change(changes);

		ChooseNewQuestion();
	}

	void Change(Relations changes) {
		/// Apply changes to reputation (by action of question)
		relations.Apply(changes);
	}

	void ChooseNewQuestion() {
		/// Choose new random questioт
		questionnum = Random.Range(1,questions.Length);
		question = questions[questionnum];

		CheckRelations();

		Redraw();
	}

	void Redraw() {
		text.text=LangController.Global.GetString("q"+questionnum);

		ChurchSlider.value=relations.church;
		ArmySlider.value=relations.army;
		EconomicsSlider.value=relations.economics;
		PeopleSlider.value=relations.people;

		PointsText.text=Points.ToString();
	}

	void CheckRelations() {
		/// Checking, if any of relations<0 or >100
		if (relations.army<-100||relations.church<-100||relations.economics<-100||relations.people<-100||relations.army>100||relations.church>100||relations.economics>100||relations.people>100) {
			SceneManager.LoadScene("LostMenu");
		}

		Points = Mathf.Abs(0-relations.army);
		Points += Mathf.Abs(0-relations.church);
		Points += Mathf.Abs(0-relations.economics);
		Points += Mathf.Abs(0-relations.people);
	}
}

public class Question {
	/// Class of independent question
	public Relations changes;
}

public class Relations{
	/// Relations pack class
	public Relations (int economicsadd, int peopleadd, int armyadd, int churchadd) {
		church=churchadd;
		army = armyadd;
		people=peopleadd;
		economics=economicsadd;
	}
	public int church;
	public int army;
	public int people;
	public int economics;

	public void Apply(Relations applied) {
		/// Void to summ Relations classes
		church+=applied.church;
		army+=applied.army;
		people+=applied.people;
		economics+=applied.economics;
		}
	public Relations Invert() {

		Relations temp = this;

		temp.church*=-1;
		temp.army*=-1;
		temp.people*=-1;
		temp.economics*=-1;

		return temp;
	}
}