using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEnergy : MonoBehaviour
{
    public static Vector3 hako;
    [SerializeField] Text text;
    public static float katahaba = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            hako = gameObject.transform.localScale;
            hako.x += katahaba;
            gameObject.transform.localScale = hako;
        }
        text.text = $"�����F{hako.x}m�i���:�_�j\n�g��: {hako.y}m";
    }
}
