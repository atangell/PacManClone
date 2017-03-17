using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public float speed = 0.4f;
    Vector2 vect = Vector2.zero;

	// Use this for initialization
	void Start () {

        vect = transform.position;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector2 p = Vector2.MoveTowards(transform.position, vect, speed);
        GetComponent < Rigidbody2D>().MovePosition(p);

        if ((Vector2)transform.position == vect)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                vect = (Vector2)transform.position + Vector2.up;
            if (Input.GetKey(KeyCode.RightArrow) )
                vect = (Vector2)transform.position + Vector2.right;
            if (Input.GetKey(KeyCode.DownArrow) )
                vect = (Vector2)transform.position - Vector2.down;
            if (Input.GetKey(KeyCode.LeftArrow) )
                vect = (Vector2)transform.position - Vector2.left;
        }
    }

    //bool valid (Vector2 dir)
    //{
    //    Vector2 pos = transform.position;
    //    RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
    //    return (hit.collider == GetComponent<Collider2D>());
    //}
}
