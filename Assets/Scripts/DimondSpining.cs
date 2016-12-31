using UnityEngine;
using System.Collections;

public class DimondSpining : MonoBehaviour {
	
	[SerializeField]
	private float rotateSpeed = 2.0f; // In rotations per second


	// Use this for initialization
	void Start () {
		transform.Rotate (transform.up, Random.Range (0f, 360f));
	}

	void Update() {
		Spin ();
	}

	private void Spin()
	{
		transform.Rotate (Vector3.up, 360 * rotateSpeed * Time.deltaTime);
	}

    void OnTriggerEnter(Collider collider)
    {
        if(ScoreManager.score>=15)
        {
            Destroy(gameObject);
            ScoreManager.score -= 15;
            if(UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed < 2.0f)
            {
                UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed *= 2.5f;
                UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_WalkSpeed *= 2.5f;
                GameObject soundManager = GameObject.Find("SoundManager");
                soundManager.GetComponent<CoinSound>().play(1);
            }
            else
            {
                UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed *= 1.5f;
                UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_WalkSpeed *= 1.5f;
                GameObject soundManager = GameObject.Find("SoundManager");
                soundManager.GetComponent<CoinSound>().play(1);
            }
            
            
        }
        
    }
}
