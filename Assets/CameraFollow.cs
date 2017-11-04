using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    Vector3 velocity;

	void FixedUpdate () {
        if(target)
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(target.position.x, transform.position.y, target.position.z), ref velocity, 0.2f);
	}
}
