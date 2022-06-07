using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushItem : MonoBehaviour
{
    [SerializeField] float tap = 0f;
    [SerializeField] float upPoints;
    [SerializeField] float buy;
    void Update()
    {
        BuyEnergy.hako.x += (upPoints * tap); //ëùâ¡
    }
    public void OnClick()
    {

        BuyEnergy.hako.x -= buy * tap; //âøäi
        tap += 1;
    }
}
