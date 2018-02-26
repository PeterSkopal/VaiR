using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownController : MonoBehaviour {

    Dropdown m_Dropdown;
	public Canvas canvas;

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
            Global.setScenario(m_Dropdown.value);
            Global.count = 0;
			MenuCanvasController.Hide(canvas);
          //  Global.setScenario(m_Dropdown.value);
        });

        //Initialise the Text to say the first value of the Dropdown
       // m_Text.text = "First Value : " + m_Dropdown.value;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
