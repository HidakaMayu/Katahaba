using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ivent : MonoBehaviour
{
    //[SerializeField] GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if(Time.frameCount % 2.0 == 0)
        //{
        //    float x = Random.Range(-5.0f, 5.0f);
        //    float y = Random.Range(-5.0f, 5.0f);
        //    Vector3 pos = new Vector3(x, y, 0f);
        //    Instantiate(gameObject, pos, Quaternion.identity);
        //    Invoke(nameof(OnDes), 10.0f); //ƒŒƒNƒgtransform
        //}
        
    }
    private void OnDes()
    {
        Destroy(gameObject);
    }
}
