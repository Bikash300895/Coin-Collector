using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        ScoreManager.score += 1;
        GameObject soundManager = GameObject.Find("SoundManager");
        soundManager.GetComponent<CoinSound>().play(0);

    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
