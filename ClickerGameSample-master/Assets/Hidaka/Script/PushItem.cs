using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushItem : TapCount
{
    [SerializeField] float upPoints;
    [SerializeField] float buy;
    [SerializeField] Text text;　//使用数
    [SerializeField] Text prctx; //価格
    [SerializeField] string work; //内容

    [SerializeField] float tap = 0f; //デバック用
    float price;
    void Start()
    {
        price = buy;
        text.text = $"×{tap}";
        GetComponent<Button>().interactable = false;
    }
    void Update()
    {
        
        if (BuyEnergy.hako.x > buy && BuyEnergy.hako.x > price) GetComponent<Button>().interactable = true;
        else GetComponent<Button>().interactable = false;

        //表示部分
        if (price == 0) prctx.text = $"{work}\n{buy}cm";
        else prctx.text = $"{work}\n{price}cm";
        BuyEnergy.hako.x += (upPoints * tap); //増加
        text.text = $"×{tap}";
    }
    public void OnClick()
    {
        if (buy == 0)
        {
            BuyEnergy.hako.x -= buy; //価格
        }
        else BuyEnergy.hako.x -= price; //価格
        tap += 1;
        price += buy * tap;
    }
}
