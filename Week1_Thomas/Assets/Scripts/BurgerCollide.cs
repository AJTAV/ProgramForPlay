using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BurgerCollide : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public static float ttl = 50.0f;
    public bool doneFlag = true;

    void Update()
    {
        BurgerCollide.ttl -= Time.deltaTime;

        if (BurgerCollide.ttl <= 0)
        {
            if (doneFlag)
            {
                Debug.Log("Game Over");
                doneFlag = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {

        Debug.Log("Yummy hamburger!");
        Destroy(gameObject);
        BurgerCollide.ttl = 50.0f;
    }
}
