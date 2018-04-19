using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
	Button button;
	public Canvas SelectModeCanvas;
	public Canvas SelectScenarioCanvas;
	public Text buttonClickedText;
	// Use this for initialization
	void Start () {
		button = GetComponent<Button>();
        switch (button.name)
        {
            case "Instructional":
                button.onClick.AddListener(TaskOnClickInstructional);
                break;
            case "Reality":
                button.onClick.AddListener(TaskOnClickReality);
                break;
            case "ChangeModeButton":
                button.onClick.AddListener(TaskOnClickChangeMode);
                break;
            case "NewScenarioButton":
                button.onClick.AddListener(TaskOnClickSelectScenario);
                break;
            default:
                print("Button not found");
                break;
        }
 
	}

	void TaskOnClickInstructional () {
		Global.mode = "Instructional";
		MenuCanvasController.Hide(SelectModeCanvas);
		MenuCanvasController.Show(SelectScenarioCanvas);
	}

    void TaskOnClickReality()
    {
        Global.mode = "Reality";
        MenuCanvasController.Hide(SelectModeCanvas);
        MenuCanvasController.Show(SelectScenarioCanvas);
    }

    void TaskOnClickChangeMode()
    {
        MenuCanvasController.Hide(SelectScenarioCanvas);
        MenuCanvasController.Show(SelectModeCanvas);
    }

    void TaskOnClickSelectScenario()
    {
        MenuCanvasController.Hide(SelectModeCanvas);
        MenuCanvasController.Show(SelectScenarioCanvas);
		buttonClickedText.text = "Select a new scenario!";
    }
}
