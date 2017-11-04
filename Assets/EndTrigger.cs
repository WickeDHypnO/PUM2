using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {

    public GameObject arrow;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().isKinematic = true;
        FindObjectOfType<GameController>().EndGame();
        FindObjectOfType<Timer>().counting = false;
        if(PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name) > FindObjectOfType<Timer>().timer)
        PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, FindObjectOfType<Timer>().timer);
    }

    private void OnBecameVisible()
    {
        arrow.SetActive(false);
    }

    private void OnBecameInvisible()
    {
        if(arrow && !arrow.activeInHierarchy)
        {
            arrow.SetActive(true);
        }
    }
}
