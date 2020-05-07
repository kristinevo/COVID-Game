using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class IntroHandler : MonoBehaviour { 
    [SerializeField] private TypeWriter type;
    public Text page_1;
    public Text page_2;
    public Text page_3;
    public Text page_4;
    public Text pageNumber;
    public Button forward;
    public Button back;
    private int page = 0;
    Text[] text = new Text[4];

    void Start()
    {
        text[0] = page_1;
        text[1] = page_2;
        text[2] = page_3;
        text[3] = page_4;
        foreach (Text t in text){
            t.GetComponent<Text>().enabled = false;
        }
        back.interactable = false;
        text[page].GetComponent<Text>().enabled = true;
        Transition();
        pageNumber.text = "Page: " + (page + 1) + "/4";
        clicked();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void clicked()
    {
        forward.onClick.AddListener(() => {
            text[page].GetComponent<Text>().enabled = false;
            page++;


            if (page == 1)
            {
                back.interactable = true;
                text[page].GetComponent<Text>().enabled = true;
                Transition();
                pageNumber.text = "Page: " + (page + 1) + "/4";
            }

            else if (page == 4)
            {
                Transition();
            }
            else 
            {
                text[page].GetComponent<Text>().enabled = true;
                Transition();
                pageNumber.text = "Page: " + (page + 1) + "/4";
            }
        });


        back.onClick.AddListener(() => {
            page--;
            if (page == 0)
            {
                back.interactable = false;
            }
            text[page].GetComponent<Text>().enabled = false;
            text[page].GetComponent<Text>().enabled = true;
            Transition();
            pageNumber.text = "Page: " + (page + 1) + "/4";
        });
    }

    public void Transition()
    {
        if (page >= 0 && page <= 3)
        {
            type.CallText(text[page]);
        }
        else
        {
            SceneManager.LoadScene("main");
        }
    }
}
