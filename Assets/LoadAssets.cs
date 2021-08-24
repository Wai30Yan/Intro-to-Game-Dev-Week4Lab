using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;

    Vector3 redPos;
    Vector3 bluePos;

    // Start is called before the first frame update
    void Start()
    {
        redPos = new Vector3(2, 0, 0);
        Instantiate(redObj, redPos, Quaternion.identity);

        bluePos = new Vector3(-2, 0, 0);
        Instantiate(blueObj, bluePos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
