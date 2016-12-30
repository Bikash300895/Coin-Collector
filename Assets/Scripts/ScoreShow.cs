using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreShow : MonoBehaviour {
    public Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText.text = "Score : " + ScoreManager.score.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
