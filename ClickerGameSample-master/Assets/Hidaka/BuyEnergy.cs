using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEnergy : MonoBehaviour
{
    Vector3 hako;
    [SerializeField] Text text;
    float katahaba;

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
            hako.x += 0.001f;
            gameObject.transform.localScale = hako;
        }
        text.text = $"�����F{hako.x}m�i���:�_�j\n�g��: {hako.y}m(�]�� * ���)";
    }
}
