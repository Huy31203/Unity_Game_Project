using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
	Player player;

	private void Awake()
	{
		player = FindObjectOfType<Player>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			player.Die();
		}
	}
}
