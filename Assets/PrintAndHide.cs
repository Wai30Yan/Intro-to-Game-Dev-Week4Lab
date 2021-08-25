using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    public GameObject gameObj;

    int i = 3;
    int iBlue;

    // Start is called before the first frame update
    void Start()
    {
        iBlue = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObj.name + ":" + i);

        if (gameObj == GameObject.FindWithTag("Red") && i == 100)
        {
            gameObj.SetActive(false);
            Debug.Log(gameObj.name + ":" + i);    
        }

        if (gameObj == GameObject.FindWithTag("Blue") && i == iBlue)
        {
            rend.enabled = false;
        }
    }
}
