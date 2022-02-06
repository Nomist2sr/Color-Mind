using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose_color : MonoBehaviour
{
    public Color currentColor;
    public bool includeColor;

    public List<Color> colorList = new List<Color>()
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
    };

    public List<string> colorStringList = new List<string>()
    {
        "red",
        "green",
        "blue",
        "yellow",
    };

    public List<int> evenList = new List<int>()
    {
        0,
        2,
        4,
    };

    public List<int> oddList = new List<int>()
    {
        1,
        3,
        5,
    };

    void Start()
    {
        newBlock();
    }

    void newBlock() {
        int nextColorNb = Random.Range(0, 3);
        int nbNot;
        includeColor = Random.value > 0.5f;
        currentColor = colorList[nextColorNb];
        Text instruction = GameObject.Find("Canvas/instruction").GetComponent<Text>();
        instruction.color = colorList[Random.Range(0, 3)];
        if (includeColor == true)
            nbNot = evenList[Random.Range(0, 2)];
        else
            nbNot = oddList[Random.Range(0, 2)];
        instruction.text = "";
        while(nbNot != 0) {
            nbNot--;
            instruction.text += "not\n";
        }
        instruction.text += colorStringList[nextColorNb];
        //changeBorderColor();
    }

    void changeBorderColor() {
        List<Color> borders = new List<Color>(4);
        //borders[0] = GameObject.Find("Canvas/instruction").GetComponent<Text>();
    }

    void Update()
    {
        
    }
}
