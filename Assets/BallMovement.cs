using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour {

    Rigidbody rigid;
    float right, up;
    public float speed = 30;
    public bool move;

	void Start () {
        rigid = GetComponent<Rigidbody>();
	}

	void Update () {
        if(!move)
        {
            return;
        }
#if UNITY_EDITOR
        if(Input.GetAxis("Horizontal") != 0)
        {
            right = Input.GetAxis("Horizontal") * 0.5f;
        }
        else
        {
            right = 0;
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            up = Input.GetAxis("Vertical") * 0.5f;
        }
        else
        {
            up = 0;
        }
#elif UNITY_ANDROID
        if(Input.acceleration.x != 0)
        {
            right = Input.acceleration.x;
        }
        else
        {
            right = 0;
        }
        if(Input.acceleration.y != 0)
        {
            up = Input.acceleration.y;
        }
        else
        {
            up = 0;
        }
#endif
    }

    void FixedUpdate()
    {
        if(right != 0)
        {
            rigid.AddForce(Vector3.right * right * speed);
        }
        if (up != 0)
        {
            rigid.AddForce(Vector3.forward * up * speed);
        }
    }
}
