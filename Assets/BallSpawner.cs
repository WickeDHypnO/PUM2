using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public Transform startingPoint;
    public CameraFollow camera;

    void Start()
    {
    }

    public void RespawnBall()
    {
        camera.target = Instantiate(ball, startingPoint.position, Quaternion.identity).transform;
        camera.target.GetComponent<BallMovement>().move = true;
    }
}
