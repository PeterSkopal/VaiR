using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour {

	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			SceneManager.LoadScene (1);
		}
	}
}
