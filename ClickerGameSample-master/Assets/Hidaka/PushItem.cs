using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushItem : MonoBehaviour
{
    public float tap = 0f;
    [SerializeField] float upPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BuyEnergy.hako.x += (upPoints * tap);
    }
    public void OnClick()
    {

        BuyEnergy.hako.x -= 0.05f * tap;
        tap += 1;
    }
}
