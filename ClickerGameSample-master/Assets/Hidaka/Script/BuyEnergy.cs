using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyEnergy : TapCount
{
    public static Vector3 hako;
    [SerializeField] Text text;
    public static int kourin = 1;
    public Ivent ivent;

    // Start is called before the first frame update
    void Start()
    {
        TapCount tapCount = new TapCount();
        hako = gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        TapWindow();
        gameObject.transform.localScale = hako;
        text.text = $"肩幅：{hako.x}m（状態:棒）\nタップ数:{tapc}回 身長: {hako.y}m";
        if (tapc > 50 * kourin)//もしタップ数一定以上だったらイベント呼び出し
        {
            Debug.Log("ok");
            ivent.Kourin();
            kourin++;
        }
    }
    protected override void TapWindow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hako.x += katahaba;
            tapc++;
        }
    }
}
