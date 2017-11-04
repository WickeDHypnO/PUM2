using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTarget : MonoBehaviour {

    public Transform target;
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.LookRotation(transform.parent.position - new Vector3(target.position.x, transform.parent.position.y, target.position.z) );
	}
}
