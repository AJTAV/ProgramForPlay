using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	public Transform car;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=new Vector3(car.position.x, car.position.y, transform.position.z);
	}
}
