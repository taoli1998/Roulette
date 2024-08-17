using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public GameObject sphere;
    void Start()
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<Renderer>().material.color = Color.blue;
        sphere.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        int random_number = Random.Range(1, 3);
        //int random_number = Random.Range(1, 38);
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            //int selected_number = Random.Range(1, 38);
            int selected_number = 2;
            if (random_number == selected_number)
            {
                sphere.GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                sphere.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

}
