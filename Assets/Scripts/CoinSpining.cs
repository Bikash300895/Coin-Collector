using UnityEngine;
using System.Collections;

public class CoinSpining : MonoBehaviour {
	
	[SerializeField]
	private float rotateSpeed = 1.0f; // In rotations per second


	// Use this for initialization
	void Start () {
		transform.Rotate (transform.up, Random.Range (0f, 360f));
	}

	void Update() {
		Spin ();
	}

	private void Spin()
	{
		transform.Rotate (Vector3.forward, 360 * rotateSpeed * Time.deltaTime);
	}
}
