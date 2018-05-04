using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownController : MonoBehaviour {

    Dropdown m_Dropdown;
	public Canvas canvas;
	public Text buttonClickedText;
    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();
        m_Dropdown.onValueChanged.AddListener(delegate {
            Global.setScenario(m_Dropdown.value);
            Global.count = 0;
			MenuCanvasController.Hide(canvas);
            buttonClickedText.color = Color.black;
			buttonClickedText.text = Global.currentScenario [0, 2];
        });
    }
}
