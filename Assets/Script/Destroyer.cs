using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	float lifetime = 2.0f;

	void Update()
	{
    	foreach(GameObject bounce in GameObject.FindGameObjectsWithTag("Bounce"))
		{
			Destroy(bounce, lifetime);
		}
	}
}
