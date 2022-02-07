using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetAllColors : MonoBehaviour
{
    public Color currentColor = Color.black;
    public bool includeColor;

    public List<Color> colorList = new List<Color>()
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow
    };

    public List<string> colorStringList = new List<string>()
    {
        "red",
        "green",
        "blue",
        "yellow"
    };

    public List<int> evenList = new List<int>()
    {
        0,
        2,
        4
    };

    public List<int> oddList = new List<int>()
    {
        1,
        3,
        5
    };

    void Start()
    {
        newBlock();
    }

    public void newBlock()
    {
        int nextColorNb = Random.Range(0, 3);
        int nbNot;
        includeColor = Random.value > 0.5f;
        currentColor = colorList[nextColorNb];
        Text instruction = GameObject.Find("Canvas/Challenge Instruction").GetComponent<Text>();
        instruction.color = colorList[Random.Range(0, 3)];
        if (includeColor == true)
            nbNot = evenList[Random.Range(0, 2)];
        else
            nbNot = oddList[Random.Range(0, 2)];
        instruction.text = "";
        while(nbNot != 0)
        {
            nbNot--;
            instruction.text += "not\n";
        }
        instruction.text += colorStringList[nextColorNb];
        changeBorderColor();
    }

    void changeBorderColor()
    {
        Color newColor;
        bool doable = true;
        List<Renderer> borders = new List<Renderer>()
        {
            GameObject.Find("Display/Map/Top Border").GetComponent<Renderer>(),
            GameObject.Find("Display/Map/Left Border").GetComponent<Renderer>(),
            GameObject.Find("Display/Map/Right Border").GetComponent<Renderer>(),
            GameObject.Find("Display/Map/Bottom Border").GetComponent<Renderer>()
        };
        borders[0].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        borders[1].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        borders[2].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        borders[3].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        for (int i = 0; i != 3; i++)
        {
            if (includeColor == true && borders[i].material.color == currentColor ||
                includeColor == false && borders[i].material.color != currentColor)
                doable = true;
        }
        if (doable == false) {
            if (includeColor == true)
                borders[Random.Range(0, 3)].material.SetColor("_Color", currentColor);
            else {
                newColor = colorList[Random.Range(0, 3)];
                while (newColor == currentColor)
                    newColor = colorList[Random.Range(0, 3)];
                borders[Random.Range(0, 3)].material.SetColor("_Color", currentColor);
            }
        }
    }

    void Update()
    {
    }
}