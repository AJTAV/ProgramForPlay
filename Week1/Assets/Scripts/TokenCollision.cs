﻿using UnityEngine;
using System.Collections;

public class TokenCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Boom");
		Destroy(gameObject);
	}
}
