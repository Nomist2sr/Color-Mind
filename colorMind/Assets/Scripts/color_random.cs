using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_random : MonoBehaviour
{
    public List<Color> colorList = new List<Color>()
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
    };

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, 3);
        GetComponent<Renderer>().material.SetColor("_Color", colorList[randomIndex]);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
