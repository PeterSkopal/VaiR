using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
	Button button;
	public Canvas SelectModeCanvas;
	public Canvas SelectScenarioCanvas;
	public Text buttonClickedText;
	public Text countCanvasText;
	public Canvas ProgressCanvas;
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
			case "RestartScenarioButton":
				button.onClick.AddListener(TaskOnClickRestartScenario);
				break;
			case "Play":
				button.onClick.AddListener(TaskOnClickPlay);
				break;
            default:
                print("Button not found");
                break;
        }
 
	}

	void TaskOnClickRestartScenario () {
		Global.count = 0;
		Global.incorrectClickCounter = 0;
		countCanvasText.text = Global.count.ToString() + " / " + (Global.currentScenario.Length / Global.itemSize).ToString();
		buttonClickedText.text = Global.currentScenario[Global.count, 2];
		//MenuCanvasController.Show(SelectScenarioCanvas);
	}

	void TaskOnClickPlay () {
		Global.setScenario (0);
		Global.count = 0;
		ProgressCanvas.enabled = true;
		countCanvasText.text = Global.count.ToString() + " / " + (Global.currentScenario.Length / Global.itemSize).ToString();
		buttonClickedText.text = Global.currentScenario[Global.count, 2];
		MenuCanvasController.Hide(SelectModeCanvas);
		//MenuCanvasController.Show(SelectScenarioCanvas);
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
		(GameObject.Find(Global.currentScenario[Global.count,0]).GetComponent("Halo") as Behaviour).enabled = false;
		Global.count = 0;
		Global.incorrectClickCounter = 0;
		buttonClickedText.text = "Select a new scenario!";

    }
}
