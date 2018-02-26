using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrucionalSelection : MonoBehaviour {
	Button button;
	public Canvas SelectModeCanvas;
	public Canvas SelectScenarioCanvas;
	// Use this for initialization
	void Start () {
		button = GetComponent<Button>();
		button.onClick.AddListener (TaskOnClick);
	}

	// Update is called once per frame
	void TaskOnClick () {
		Global.mode = "Instructional";
		//Canvas canvas = button.GetComponentInParent<Canvas>();
		MenuCanvasController.Hide(SelectModeCanvas);
		MenuCanvasController.Show(SelectScenarioCanvas);
	}
}
