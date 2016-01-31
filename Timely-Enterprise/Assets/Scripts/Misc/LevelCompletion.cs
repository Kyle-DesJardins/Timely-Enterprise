using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelCompletion : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Item") {
			if(SceneManager.GetActiveScene().buildIndex + 1 != 6) {
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
			else {
				SceneManager.LoadScene(0);
			}
		}
	}
}
