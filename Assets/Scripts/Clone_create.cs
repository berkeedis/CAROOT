using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone_create : MonoBehaviour
{

    public GameObject gold;
    public GameObject Car_2;
    public GameObject Taxi;
    public GameObject Police_car;
    public GameObject magnet;

    public Transform CarMove;

    float delete_time = 5.0f;

    float right_X_coordinate = -1.2f;
    float left_X_coordinate = -7.20f;

    void Start()
    {
        InvokeRepeating("clone_object", 0, 0.6f);
    }

    void clone_object()
    {
        int random_number = Random.Range(0, 100);

        if (random_number > 0 && random_number < 80)
        {
            generate(gold, 1.0f);
        }

        if (random_number > 80 && random_number < 85)
        {
            generate(Car_2, 0.2f);
        }

        if (random_number > 85 && random_number < 90)
        {
            generate(Taxi, 0.2f);
        }

        if (random_number > 90 && random_number < 97)
        {
            generate(Police_car, 0.2f);
        }

        if (random_number > 97 && random_number < 100)
        {
            if (CarMove.gameObject.GetComponent<CarMove>().take_magnet == false)
            {
                generate(magnet, 1.0f);
            }
        }

    }

    void generate(GameObject gameobject, float Y_coordinate)
    {
        GameObject new_clone = Instantiate(gameobject);

        int random_number = Random.Range(0, 100);

        if (random_number < 50)
        {
            new_clone.transform.position = new Vector3(right_X_coordinate, Y_coordinate, CarMove.position.z + 20.0f);
        }
        else if (random_number > 50)
        {
            new_clone.transform.position = new Vector3(left_X_coordinate, Y_coordinate, CarMove.position.z + 20.0f);
        }

        Destroy(new_clone, delete_time);
    }
}
