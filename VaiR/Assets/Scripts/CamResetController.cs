using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamResetController : MonoBehaviour {
//	public Button lookAtButton;
	// Use this for initialization
	void Start () {
		GvrCardboardHelpers.Recenter();
	}
}
