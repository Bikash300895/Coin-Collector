using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour {

    public AudioClip[] sounds;
    AudioSource musicPlayer;

	// Use this for initialization
	void Start () {
        musicPlayer = GetComponent<AudioSource>();
        
        
	}

    public void play(int i)
    {
        musicPlayer.clip = sounds[i];
        musicPlayer.Play();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
