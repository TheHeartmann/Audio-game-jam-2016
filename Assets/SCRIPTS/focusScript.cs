using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class focusScript : MonoBehaviour {
	public AudioMixerSnapshot normal;
	public AudioMixerSnapshot focus;

	public float transitionTime;

	// Use this for initialization
	void Start() {
	}
	
	// Update is called once per frame
	void Update() {
		if(Input.GetKeyDown(KeyCode.E)) {
			focus.TransitionTo(transitionTime);
		} else if(Input.GetKeyUp(KeyCode.E)) {
			normal.TransitionTo(transitionTime);
		}
	
	}

	void Focus() {
		focus.TransitionTo(.5f);
	}
}

