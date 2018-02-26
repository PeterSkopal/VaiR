
	using UnityEngine;
    using UnityEngine.UI;

    [RequireComponent(typeof(Collider))]
	public class FlowController : MonoBehaviour {

    public Text buttonClickedText;

    public void ButtonClicked(string name)
    {
        print(Global.currentScenario);
        print(name);

        if (Global.currentScenario == null || Global.currentScenario.Length == Global.count)
        {
            print("Select a new scenario!");
            buttonClickedText.text = "Select a new scenario!" ;
            buttonClickedText.color = Color.Lerp(Color.clear, Color.green, 5);
        }
        else
        {
            string currentName = Global.currentScenario[Global.count];
            if (name.Equals(currentName))
            {
                Global.count = Global.count + 1;
                correctClick(name);
            }
            else
            {
                incorrectClick(name);
            }
        }
    }

    public void incorrectClick(string buttonName) {
        print("Wrong button!\t" + buttonName);
        buttonClickedText.text = "Wrong Button!";
        buttonClickedText.color = Color.Lerp(Color.clear, Color.green, 5);
    }

		public void correctClick(string buttonName) {
        print("Correct button!\t" + buttonName);
        buttonClickedText.text = "Correct button";
        buttonClickedText.color = Color.Lerp(Color.clear, Color.green, 5);
    }

	}
