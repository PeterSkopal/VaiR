
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
        if (Global.currentScenario == null || (Global.currentScenario.Length / 2) == Global.count)
        {
            buttonClickedText.text = "Select a new scenario!";
        }
        else
        {
            string currentName = Global.currentScenario[Global.count,0];
            if (name.Equals(currentName))
            {
                Global.count = Global.count + 1;
                if (Global.count == Global.currentScenario.Length / 2) {
                    buttonClickedText.text = "Good Job! Select a new scenario!";
                    buttonClickedText.color = correctColor;
                    MenuCanvasController.Show(SelectScenarioCanvas);
                } else {
                    buttonClickedText.text = Global.currentScenario[Global.count,1];
                }
                Renderer rend = GetComponent<Renderer>();
                (GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = false;
                Global.incorrectClickCounter = 0;
                correctClick(name);
            }
            else
            {
                Global.incorrectClickCounter = Global.incorrectClickCounter + 1;
                if (Global.incorrectClickCounter > 2)
                {
                    buttonClickedText.text = "Look Around to find a hint!";
                    Renderer rend = GetComponent<Renderer>();
                    (GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = true;
                }
                incorrectClick(name);
            }
            print(Global.incorrectClickCounter);
        }
    }

    public void incorrectClick(string buttonName) {
		incorrectSound.Play();
        StartCoroutine(BlinkButton(buttonName, false));
    }

    public void correctClick(string buttonName) {
		correctSound.Play();
        StartCoroutine(BlinkButton(buttonName, true));
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

    public void ButtonLookedAt(string name)
    {
        StartCoroutine(GazeCheck(name));
    }

    IEnumerator GazeCheck(string name) { 
        string currentName = Global.currentScenario[Global.count, 0];
        if (name.Equals(currentName))
        {
            yield return new WaitForSecondsRealtime(1f);
       
                Global.count = Global.count + 1;
                buttonClickedText.text = Global.currentScenario[Global.count, 1];
                Renderer rend = GetComponent<Renderer>();
                (GameObject.Find(currentName).GetComponent("Halo") as Behaviour).enabled = false;
                Global.incorrectClickCounter = 0;
                correctClick(name);
                print("hello from button looked at: " + name);
                yield return new WaitForSecondsRealtime(1f);
            
        }
}

}
