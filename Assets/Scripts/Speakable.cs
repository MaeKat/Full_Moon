using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speakable : MonoBehaviour
{
    public Text theText;

    public TextAsset textfile;
    public String[] dialogue;

    public int currLine;
    public int endAtLine;

    public PlayerMovement player;

    public BoxCollider2D speakerBox;
    public BoxCollider2D alfieBox;
    public Boolean isTouching = false;

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
            endAtLine = dialogue.Length - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = dialogue[currLine];

        if (alfieBox.IsTouching(speakerBox)) {
            isTouching = true;
        }

        if (alfieBox.IsTouching(speakerBox) && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)))
        {
            currLine += 1;
        }

        if (currLine >= endAtLine)
        {
            currLine = 0;
        }
    }
}
