using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioAndModeSelection : MonoBehaviour {
	Button button;
	public Canvas SelectScenarioCanvas;
	// Use this for initialization
	void Start () {
		button = GetComponent<Button>();
		button.onClick.AddListener (TaskOnClick);
	}

	// Update is called once per frame
	void TaskOnClick () {
		//Canvas canvas = button.GetComponentInParent<Canvas>();
		MenuCanvasController.Show(SelectScenarioCanvas);
	}
}
