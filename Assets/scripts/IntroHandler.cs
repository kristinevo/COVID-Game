using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroHandler : MonoBehaviour { 
    [SerializeField] private TypeWriter type; 
    private Text page_1;
    private Text page_2;
    private Text page_3;
    private int page = 0;

    // Start is called before the first frame update
    void Start()
    {
        String[] text = { page_1.text, page_2.text, page_3.text };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
