﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void FixedUpdate () {
        transform.Rotate(new Vector3(0,1,0));
	}
}
