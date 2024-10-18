using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
	[SerializeField]
	private FloatSO scoreSO;
	
	public float rotationSpeed = 100f;

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			scoreSO.Value++;
			Destroy(gameObject);
		}

        if (other.gameObject.CompareTag("Barricade"))
        {
			Destroy(gameObject);
		}
    }
}
