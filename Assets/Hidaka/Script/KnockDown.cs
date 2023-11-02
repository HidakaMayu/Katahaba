using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class KnockDown : MonoBehaviour
{
    [SerializeField] GameObject explosion; //爆発用パーティクル
    [SerializeField]float impulse = 0.00001f; //爆発の力の大きさ

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("aaa");
        //相手がEnemyかつ自分より小さい場合
        if(collision.gameObject.tag == "Enemy" || this.transform.localScale.x >= collision.transform.localScale.x)
        {
            //飛ばす
            //ぶつかった相手からRigitBodyを取り出す
            Rigidbody otherRigitbody = collision.gameObject.GetComponent<Rigidbody>();
            if (!otherRigitbody)
            {
                return;
            }

            //吹き飛ばす方向を求める(プレイヤーから触れたものの方向)
            Vector3 toVec = GetAngleVec(this.gameObject, collision.gameObject);

            //Y方向を足す
            toVec = toVec + new Vector3(0, 3, 0);

            //吹っ飛ばし
            otherRigitbody.AddForce(toVec * impulse, ForceMode.Impulse);
            StartCoroutine("GetOut",collision.gameObject);
        }

        Vector3 GetAngleVec(GameObject _from, GameObject _to)
        {
            //高さの概念を入れないベクトルを作る
            Vector3 fromVec = new Vector3(_from.transform.position.x, 0, _from.transform.position.z);
            Vector3 toVec = new Vector3(_to.transform.position.x, 0, _to.transform.position.z);
            return Vector3.Normalize(toVec - fromVec);
        }
        //Destroy(collision.gameObject);
    }

    private IEnumerable GetOut(GameObject enemy)
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(enemy);
    }
}