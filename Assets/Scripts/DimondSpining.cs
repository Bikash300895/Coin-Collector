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
        if(ScoreManager.score>15)
        {
            ScoreManager.score -= 15;
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed *= 1.5f;
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_WalkSpeed *= 1.5f;
            Destroy(gameObject);
        }
        
    }
}
