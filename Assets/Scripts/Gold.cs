using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{

    CarMove car;
    Transform contact_cube;

    float range;

    void Start()
    {
        car = GameObject.Find("car").GetComponent<CarMove>();
        contact_cube = GameObject.Find("car/contact_cube").transform;
    }

    
    void Update()
    {
        if(car.take_magnet == true)
        {
            range = Vector3.Distance(transform.position, contact_cube.position);

            if(range <= 10)
            {
                transform.position = Vector3.MoveTowards(transform.position, contact_cube.position, Time.deltaTime * 15.0f);
            }
        }
    }
}
