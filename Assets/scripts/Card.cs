using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	public int value;
	public int country;
	public bool isRed;
	public bool faceUp;
	GameManager gm;

	private void Start()
	{
		gm = FindObjectOfType<GameManager>();
	}
}
