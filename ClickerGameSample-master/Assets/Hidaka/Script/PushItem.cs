using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushItem : MonoBehaviour
{
    [SerializeField] float upPoints;
    [SerializeField] float buy;
    [SerializeField] Text text;
    [SerializeField] Text prctx;
    [SerializeField] string work;

    float tap = 0f;
    float price;
    void Start()
    {
        price = buy;
        text.text = $"�~{tap}";
        GetComponent<Button>().interactable = false;
    }
    void Update()
    {
        
        if (BuyEnergy.hako.x > buy && BuyEnergy.hako.x > price) GetComponent<Button>().interactable = true;
        else GetComponent<Button>().interactable = false;

        if (price == 0) prctx.text = $"{work}\n{buy}cm";
        else prctx.text = $"{work}\n{price}cm";
        BuyEnergy.hako.x += (upPoints * tap); //����
        text.text = $"�~{tap}";
    }
    public void OnClick()
    {
        if (buy == 0)
        {
            BuyEnergy.hako.x -= buy; //���i
        }
        else BuyEnergy.hako.x -= price; //���i
        tap += 1;
        price += buy * tap;
    }
}
