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

	[SerializeField]
	private AudioSource sfx;
	[SerializeField]
	private Scrollbar sliderSFX;
	private float sliderValue;

	void Awake() {
//		music.clip = audio[0];
		slider.value = 1f;
		sliderSFX.value = 1f;
		slider.onValueChanged.AddListener(ControlVolume);
		sliderSFX.onValueChanged.AddListener(ControlSFX);
	}

	public void OnDoor() {
		sfx.clip = audio[9];
		sfx.Play();
	}

	public void OnDie() {
		sfx.clip = audio[15];
		sfx.Play();
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

	private void ControlSFX(float value) {
		sliderValue = slider.value;
		sfx.volume = sliderValue;
	}
}
