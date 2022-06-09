using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    [SerializeField] InputField inputField = null;
    [SerializeField] Text text;
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(5);
            text.text = inputField.text;
            Destroy(inputField);
        }
        
    }
}
