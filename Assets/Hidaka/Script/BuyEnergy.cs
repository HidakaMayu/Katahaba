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
        text.text = $"�����F{hako.x}m�i���:�_�j\n�^�b�v��:{tapc}�� �g��: {hako.y}m";
        if (tapc > 50 * kourin)//�����^�b�v�����ȏゾ������C�x���g�Ăяo��
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
