using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSwapper : MonoBehaviour
{
    public TextAsset newText;
    public TextImporter textOutput;
    public BoxCollider2D alfieBox;
    public BoxCollider2D trigZone;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (trigZone.IsTouching(alfieBox))
        {
            if (!(newText.name == (textOutput.textfile.name)))
            {
                textOutput.textfile = newText;
                textOutput.currLine = 0;
                textOutput.saidOnce = false;
                textOutput.dialogue = textOutput.textfile.text.Split('\n');
            }
        }
    }
}
