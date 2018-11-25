using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AutoWalk : MonoBehaviour {

    public int speed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Camera.main.transform.forward*Time.deltaTime*speed;
	}
    private void OnTriggerEnter(Collider other)
    {     
        if (other.CompareTag("trophytag"))
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
