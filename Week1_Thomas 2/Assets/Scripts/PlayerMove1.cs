using UnityEngine;
using System.Collections;

public class PlayerMove1 : MonoBehaviour {

	public float hspeed =6;
	public float vspeed=6;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h=Input.GetAxis("Horizontal");

		float v=Input.GetAxis("Vertical");

		transform.Translate(new Vector3(h*hspeed*Time.deltaTime,v*vspeed*Time.deltaTime,0));

	}
}
