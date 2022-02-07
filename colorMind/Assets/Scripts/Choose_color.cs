using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose_color : MonoBehaviour
{
    public Color currentColor = Color.black;
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

    public void newBlock() {
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
        changeBorderColor();
    }

    void changeBorderColor() {
        bool doable = false;
        Debug.Log("lesgooo");
        List<Renderer> borders = new List<Renderer>() {
            GameObject.Find("top_border").GetComponent<Renderer>(),
            GameObject.Find("left_border").GetComponent<Renderer>(),
            GameObject.Find("right_border").GetComponent<Renderer>(),
            GameObject.Find("bottom_border").GetComponent<Renderer>()
    };
        borders[0].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        borders[1].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        borders[2].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        borders[3].material.SetColor("_Color", colorList[Random.Range(0, 3)]);
        for (int i = 0; i != 3; i++) {
            if (includeColor == true && borders[i].material.color == currentColor)
                doable = true;
        }
        if (doable == false)
            borders[Random.Range(0, 3)].material.SetColor("_Color", currentColor);
    }

    void Update()
    {
        
    }
}
