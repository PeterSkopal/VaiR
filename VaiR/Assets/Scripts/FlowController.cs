
	using UnityEngine;
    using UnityEngine.UI;
    using System.Collections;

    [RequireComponent(typeof(Collider))]
	public class FlowController : MonoBehaviour {

    public Text buttonClickedText;
    public Color correctColor = Color.green;
    public Color incorrectColor = Color.red;
    public Color transparentColor = Color.clear;
    public Canvas SelectScenarioCanvas;

	public AudioSource correctSound, incorrectSound;

    public void ButtonClicked(string name)
    {	
        if (Global.currentScenario == null)
        {
            buttonClickedText.text = "Select a new scenario!";
        }
        else
        {
            string currentName = Global.currentScenario[Global.count,0];
            if (name.Equals(currentName))
            {
                if ((Global.currentScenario.Length / Global.itemSize) - 1 == Global.count) {
                    buttonClickedText.text = "Good Job! Select a new scenario!";
                    buttonClickedText.color = correctColor;
                    MenuCanvasController.Show(SelectScenarioCanvas);
                } else {
                    Global.count = Global.count + 1;
                    buttonClickedText.text = Global.currentScenario[Global.count, 2];
                }
				lightOffButton (currentName);
                correctClick(name);
            }
            else
            {
                Global.incorrectClickCounter = Global.incorrectClickCounter + 1;
                if (Global.incorrectClickCounter > 2)
                {
					lightUpButton (currentName);
                }
                incorrectClick(name);
            }
        }
    }

    public void incorrectClick(string buttonName) {
		incorrectSound.Play();
        StartCoroutine(BlinkButton(buttonName, false));
    }

    public void correctClick(string buttonName) {
		correctSound.Play();
        StartCoroutine(BlinkButton(buttonName, true));

		if (Global.currentScenario [Global.count, 1].Equals ("gaze")) {
			StartCoroutine (GazeHelp (Global.currentScenario [Global.count, 0]));
		}
    }

	IEnumerator GazeHelp(string currentName){
		yield return new WaitForSecondsRealtime(7f);
		if (Global.currentScenario [Global.count, 0].Equals (currentName)) {
			lightUpButton (currentName);
		}
	}

    IEnumerator BlinkButton(string buttonName, bool clickCorrect) {
        Renderer rend = GetComponent<Renderer>();
        GameObject button = GameObject.Find(buttonName);
        float progress = 0;
        float increment = 0.05f;
        while (progress < 1) {
            progress += increment;
                Color currentColor = transparentColor;
            if (clickCorrect) {
                currentColor = Color.Lerp(correctColor, transparentColor, progress);
            } else {
                currentColor = Color.Lerp(incorrectColor, transparentColor, progress);
            }
            button.GetComponent<Renderer>().material.color = currentColor;
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }

	public void lightOffButton(string currentName){
		Renderer rend = GetComponent<Renderer>();
		(GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = false;
		Global.incorrectClickCounter = 0;
	}

	public void lightUpButton(string currentName){
		buttonClickedText.text = "Look Around to find a hint!";
		Renderer rend = GetComponent<Renderer>();
		(GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = true;
	}

    public void ButtonLookedAt(string name)
    {
        if (Global.currentScenario != null) {
            StartCoroutine(GazeCheck(name));
        }
    }

    IEnumerator GazeCheck(string name) {
        string currentName = Global.currentScenario[Global.count, 0];
        bool ifGaze = Global.currentScenario[Global.count, 1] == "gaze";
        if (name.Equals(currentName) && ifGaze)
        {
            yield return new WaitForSecondsRealtime(1f);
    
            Global.count = Global.count + 1;
            buttonClickedText.text = Global.currentScenario[Global.count, 2];
            Renderer rend = GetComponent<Renderer>();
            (GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = false;
            Global.incorrectClickCounter = 0;
            correctClick(name);
        }
    }

}
