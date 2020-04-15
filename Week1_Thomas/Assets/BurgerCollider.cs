using UnityEngine;
using System.Collections;

public class BurgerCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D c){

		Debug.Log("Yummy hamburger!");
		Destroy(gameObject);
		
	}
}
