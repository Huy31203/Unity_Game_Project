using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatSO", menuName = "FloatSO")]
public class FloatSO : ScriptableObject
{
	[SerializeField]
	private float _score;

	public float Value
	{
		get { return _score; }
		set { _score = value; }
	}

}
