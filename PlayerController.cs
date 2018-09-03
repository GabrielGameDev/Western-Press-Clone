using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int playerIndex;

	private int keyIndex = 8;
	private bool canPlay = false;
	// Use this for initialization
	IEnumerator Start () {

		while (LevelController.instance.canPlay == false)
		{
			yield return null;
		}

		canPlay = true;

	}
	
	// Update is called once per frame
	void Update () {


		if(canPlay == false)
		{
			return;
		}

		if (Input.GetKeyDown(LevelController.instance.gameKeys[keyIndex].key))
		{
			KeyPress();
		}

	}

	void KeyPress()
	{
		LevelController.instance.NextKey(playerIndex, keyIndex);
		keyIndex--;

		if (keyIndex < 0)
			canPlay = false;
	}
}
