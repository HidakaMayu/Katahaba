using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    [SerializeField] Text text;
    InputField inputField;
    void Start()
    {
        inputField = this.GetComponent<InputField>();
        text = text.GetComponent<Text>();
        
    }

    void Update()
    {
        if(inputField != null)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                text.text = inputField.text;
                Destroy(this.gameObject);
                inputField = null;
            }
        }
    }
}
