
	using UnityEngine;
    using UnityEngine.UI;
    using System.Collections;

    [RequireComponent(typeof(Collider))]
	public class FlowController : MonoBehaviour {

    public Text buttonClickedText;
    public Text countCanvasText;
    public Color correctColor = Color.green;
    public Color incorrectColor = Color.red;
    public Color transparentColor = Color.clear;
    public Color blackColor = Color.black;
    public Canvas SelectScenarioCanvas;
    public Canvas ProgressCanvas;

	public AudioSource correctSound, incorrectSound;

    void Start () {
     //   ProgressCanvas.enabled = false;
    }

    public void ButtonClicked(string name) {
        if (Global.currentScenario == null) {
            buttonClickedText.text = "Select a new scenario!";
        } else {
            if (!gameIsDone()) {
                string currentName = Global.currentScenario[Global.count,0];
                bool isClickButton = Global.currentScenario [Global.count, 1].Equals ("button");
                if (name.Equals(currentName) && isClickButton) {
                    Global.count = Global.count + 1;
                    setCanvasTexts();
                    lightOffButton(currentName);
                    correctClick(name);
                } else {
                    incorrectClick(name, currentName);
                }
            }
        }
    }

    public void ButtonLookedAt(string name) {
        if (Global.currentScenario != null && !gameIsDone()) {
            StartCoroutine(GazeCheck(name));
        }
    }

    IEnumerator GazeCheck(string name) {
        string currentName = Global.currentScenario[Global.count, 0];
        bool ifGaze = Global.currentScenario[Global.count, 1] == "gaze";
        if (name.Equals(currentName) && ifGaze) {
            Global.count = Global.count + 1;

            yield return new WaitForSecondsRealtime(1f);
            setCanvasTexts();
            lightOffButton(currentName);
            correctClick(name);
        }
    }

    public void incorrectClick(string buttonName, string currentName) {
        Global.incorrectClickCounter = Global.incorrectClickCounter + 1;
        if (Global.incorrectClickCounter > 2) {
            lightUpButton(currentName);
        }
		incorrectSound.Play();
        StartCoroutine(BlinkButton(buttonName, false));
    }

    public void correctClick(string buttonName) {
		correctSound.Play();
        StartCoroutine(BlinkButton(buttonName, true));

		if (!gameIsDone() && Global.currentScenario [Global.count, 1].Equals ("gaze")) {
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

	public void lightOffButton(string currentName) {
		Renderer rend = GetComponent<Renderer>();
		(GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = false;
		Global.incorrectClickCounter = 0;
	}

	public void lightUpButton(string currentName) {
		buttonClickedText.text = "Look Around to find a hint!";
		Renderer rend = GetComponent<Renderer>();
		(GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = true;
	}

    public void setCanvasTexts() {
        if (!gameIsDone()) {
            ProgressCanvas.enabled = true;
            countCanvasText.text = Global.count.ToString() + " / " + (Global.currentScenario.Length / Global.itemSize).ToString();
            buttonClickedText.color = blackColor;
            buttonClickedText.text = Global.currentScenario[Global.count, 2];
        } else {
            ProgressCanvas.enabled = false;
        }
	}

    public bool gameIsDone() {
        bool done = (Global.currentScenario.Length / Global.itemSize) == Global.count;
        if (done) {
            buttonClickedText.text = "Good Job! Select a new scenario!";
            buttonClickedText.color = correctColor;
            MenuCanvasController.Show(SelectScenarioCanvas);
        }
        return done;
    }

}
