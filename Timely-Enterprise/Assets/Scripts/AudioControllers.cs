using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioControllers : MonoBehaviour {

	[SerializeField]
	private AudioSource music;
	[SerializeField]
	private AudioClip audio1;
	[SerializeField]
	private Scrollbar slider;
	private float sliderValue;

	void Awake() {
		music.clip = audio1;
		slider.value = 1f;
		slider.onValueChanged.AddListener(ControlVolume);
		//slider = volumeLevel.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	private void ControlVolume (float value) {
		sliderValue = slider.value;
		music.volume = sliderValue;
	}
}
