using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ivent : TapCount
{
    float kataDefalt = 0f;
    [SerializeField] float tr = 0.2f;
    void Start()
    {
        TapCount tapCount = new TapCount();
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TapWindow();
    }
    public void OnClick() //‰Ÿ‚·‚Æ”{‚É‚È‚é
    {
        this.gameObject.SetActive(false);
        kataDefalt = katahaba;
        katahaba *= (2 + BuyEnergy.kourin);
        Invoke(nameof(OnDes), 10.0f);
    }
    private void OnDes()
    {
        this.gameObject.SetActive(false);
        if(kataDefalt != 0f)
        {
            katahaba = kataDefalt;
            kataDefalt = 0f;
        }
    }
    public void Kourin()
    {
        this.gameObject.SetActive(true);
        Invoke(nameof(OnDes), 2.0f); 
    }
}
