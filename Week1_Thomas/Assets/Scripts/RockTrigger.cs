using UnityEngine;
using System.Collections;

public class RockTrigger : MonoBehaviour {

    public float hspeed = 6;
    public float vspeed = 6;

    // Use this for initialization

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c){
		Debug.Log("Boom");
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(1,0, 0));
    }
}
