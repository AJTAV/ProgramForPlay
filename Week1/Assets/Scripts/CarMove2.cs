using UnityEngine;
using System.Collections;

public class CarMove2 : MonoBehaviour {

	public float hspeed =6;
	public float rotspeed=60;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float r=Input.GetAxis("Horizontal");
		float f=Input.GetAxis("Vertical");

		transform.Rotate(0,0,-r*rotspeed*Time.deltaTime);


		float rotation = transform.rotation.y;
		float y_change = Mathf.Cos(rotation) * f*hspeed*Time.deltaTime;
		float x_change = Mathf.Sin(rotation) * f*hspeed*Time.deltaTime;
		
		transform.Translate(x_change, y_change, 0);


	}


}
