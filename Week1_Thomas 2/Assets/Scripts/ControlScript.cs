using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	public Transform collect;
	public Transform avoid;

	private float maxItems = 50;

	// Use this for initialization
	void Start () {
		for(int i=0; i<maxItems; i++){
			Vector2 randPosition = new Vector2(Random.Range(-50,50),Random.Range(-50,50));
			if(Random.value<.3f){
				Instantiate (collect, randPosition,Quaternion.identity);
			}else{
				Instantiate (avoid, randPosition,Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
