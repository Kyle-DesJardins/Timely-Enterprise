using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DynamicLoad : MonoBehaviour {


	// Use this for initialization
	void Start () {
		if(gameObject.tag != "Stair") {
			gameObject.GetComponent<Animator>().SetInteger("Level", SceneManager.GetActiveScene().buildIndex);
			if (SceneManager.GetActiveScene().buildIndex == 6) {
				gameObject.GetComponent<Animator>().SetInteger("Level", 4);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
