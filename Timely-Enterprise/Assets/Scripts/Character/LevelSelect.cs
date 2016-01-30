using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	public void LoadLevel1() {
		Debug.Log("Stuff");
		SceneManager.LoadScene(1);
	}
}
