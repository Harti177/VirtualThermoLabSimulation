﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShowDetails : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showDetails()
    {
        if (this.gameObject.activeSelf)
        {
            this.gameObject.SetActive(false); 
        }else
        {
            this.gameObject.SetActive(true);
        }
    }

}
