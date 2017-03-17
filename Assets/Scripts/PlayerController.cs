using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed;
    Transform myTransform;
    Vector3 direction;


    // Use this for initialization
    void Start()
    {
        myTransform = this.gameObject.GetComponent<Transform>();
        direction = new Vector3(1, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //move pacman up
            this.gameObject.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
            direction = new Vector3(0, 1, 0);
        }


        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //move pacman up
            this.gameObject.transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
            direction = new Vector3(0, -1, 0);

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //move pacman up
            this.gameObject.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            direction = new Vector3(-1, 0, 0);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //move pacman up
            this.gameObject.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
            direction = new Vector3(1, 0, 0);

        }



        //   Vector3 move = new Vector3(h, v, 0);

        myTransform.position += direction * Time.deltaTime * speed;
    }
}
