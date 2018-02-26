using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCanvasController : MonoBehaviour {
	public Canvas startCanvas;
	// Use this for initialization
	void Start () {
		startCanvas.transform.position = new Vector3 (0, 0, 1000);
	}

	public static void Show (Canvas canvas) {
		canvas.transform.position = new Vector3 (-8.732161F, 36.99228F, -108.5021F);
	}

	public static void Hide (Canvas canvas) {
		canvas.transform.position = new Vector3 (0, 0, 10000);
	}
}
