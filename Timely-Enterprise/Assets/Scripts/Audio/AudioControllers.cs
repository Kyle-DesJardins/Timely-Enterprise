using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioControllers : MonoBehaviour {

	[SerializeField]
	private AudioSource music;
	[SerializeField]
	private AudioClip[] audio;
	[SerializeField]
	private Scrollbar slider;
	private float sliderValue;

	void Awake() {
//		music.clip = audio[0];
		slider.value = 1f;
		slider.onValueChanged.AddListener(ControlVolume);
		//slider = volumeLevel.GetComponent<Slider>();
	}

	void OnLevelWasLoaded(int level) {
		music.clip = audio[SceneManager.GetActiveScene().buildIndex];
		music.Play();
	}
	
	// Update is called once per frame
	private void ControlVolume (float value) {
		sliderValue = slider.value;
		music.volume = sliderValue;
	}
}
