using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyEnergy : MonoBehaviour
{
    Vector3 hako;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            hako = gameObject.transform.localScale;
            hako.x += 0.01f;
            gameObject.transform.localScale = hako;
        }
    }
}
