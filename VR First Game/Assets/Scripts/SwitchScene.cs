﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler
{
    public float gazeTime = 2f;
    private float timer = 0f;
    private bool gazedAt = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                changescene();
                timer = 0f;
            }
        }
    }

    public void changescene()
    {
        SceneManager.LoadScene("VRGamefirst");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("pointer enter");
        gazedAt = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("pointer exit");
        gazedAt = false;
    }
}