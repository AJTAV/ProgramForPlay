using UnityEngine;
using System.Collections;

public class TokenCollision : MonoBehaviour {
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject myPrefab;

    void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("GOALLL!!!");
		Destroy(coll.collider.gameObject);
        Instantiate(myPrefab, new Vector3(-5.17f, -2.08f, 0), Quaternion.identity);

    }
}
