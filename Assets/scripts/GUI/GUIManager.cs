using UnityEngine;
using System.Collections;
using System.IO;

public class GUIManager : MonoBehaviour {
	
	SceneText sceneDescription; //the main description
	SceneText timer;
	SceneText gameStatus;
	SceneText choiceTimer;
		
	//the user choices
	ChoiceButtons choices;
	
	//the text from the file
	string textFile;
	
	void Start () {
		SceneText[] texts = gameObject.GetComponents<SceneText>();
		sceneDescription = texts[0];
		timer = texts[1];
		gameStatus = texts[2];
		choiceTimer = texts[3];
		
		initText();//Initialize the text areas
		
		choices = gameObject.GetComponent<ChoiceButtons>();
	}
	
	void initText() {
		sceneDescription.Text = "scene desc";
		timer.Text = "timer";
		gameStatus.Text = "gameStatus";
		choiceTimer.Text = "choiceTimer";
		System.IO.StreamReader sr = new System.IO.StreamReader("TheStorySoFar.txt");
		textFile = sr.ReadToEnd();
		print(textFile);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
