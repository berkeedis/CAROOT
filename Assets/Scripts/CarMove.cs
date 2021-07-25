using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    public GameObject gameover;

    public TMPro.TextMeshProUGUI point_txt;
    public TMPro.TextMeshProUGUI earn_gold_txt;

    public Transform Road_1;
    public Transform Road_2;

    bool right = true;

    int point = 0;
    int earn_gold = 0;

    public bool take_magnet = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Last_1")
        {
            Road_2.position = new Vector3(Road_1.position.x, Road_1.position.y, Road_1.position.z + 80.0f);
        }

        if (other.gameObject.name == "Last_2")
        {
            Road_1.position = new Vector3(Road_2.position.x, Road_2.position.y, Road_2.position.z + 80.0f);
        }

        if (other.gameObject.tag == "barrier")
        {
            gameover.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (other.gameObject.tag == "gold")
        {
           
            Destroy(other.gameObject);

            earn_gold++;
            point += 15;

            point_txt.text = point.ToString("00000");
            earn_gold_txt.text = earn_gold.ToString();

        }

        if (other.gameObject.tag == "magnet")
        {
            GameObject[] all_magnets = GameObject.FindGameObjectsWithTag("magnet");

            foreach (GameObject magnet in all_magnets)
            {
                Destroy(magnet);
            }

            take_magnet = true;
            Invoke("reset_magnet", 10.0f);

        }
    }

    void reset_magnet()
    {
        take_magnet = false;
    }


    void Update()
    {
        move();
    }

    void move()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            right = false;
        }

        if (right)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-1.55f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-6.85f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }

        transform.Translate(0, 0, 10 * Time.deltaTime);
    }
}
