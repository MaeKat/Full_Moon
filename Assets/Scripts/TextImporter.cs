using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour
{
    public Text theText;

    public TextAsset textfile;
    public String[] dialogue;

    public int currLine;
    public int endAtLine;

    public PlayerMovement player;

    public Boolean onlySpeakOnce;
    public Boolean saidOnce = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

        if (textfile != null)
        {
            dialogue = (textfile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = dialogue.Length-1;
        }
    }

    void Update()
    {
        if (onlySpeakOnce && saidOnce)
        {
            theText.text = "";
        }
        else
        {
            theText.text = dialogue[currLine];

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                currLine += 1;
            }

            if (currLine > endAtLine)
            {
                currLine = 0;
                saidOnce = true;
            }
        }

        

    }
}
