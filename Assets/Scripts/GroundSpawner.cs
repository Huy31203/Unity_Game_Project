using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
	public static GroundSpawner instance;
	public GameObject groundTile;

	private Vector3 nextSpawnPoint;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	void Start()
	{
		for (int i = 0; i < 50; i++)
		{
			SpawnTile();
		}

	}

	public void SpawnTile()
	{
		GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
		nextSpawnPoint = temp.transform.GetChild(1).transform.position;
	}
}
