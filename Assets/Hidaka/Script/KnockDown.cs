using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class KnockDown : MonoBehaviour
{
    [SerializeField] GameObject explosion; //�����p�p�[�e�B�N��
    [SerializeField]float impulse = 0.00001f; //�����̗͂̑傫��

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("aaa");
        //���肪Enemy��������菬�����ꍇ
        if(collision.gameObject.tag == "Enemy" || this.transform.localScale.x >= collision.transform.localScale.x)
        {
            //��΂�
            //�Ԃ��������肩��RigitBody�����o��
            Rigidbody otherRigitbody = collision.gameObject.GetComponent<Rigidbody>();
            if (!otherRigitbody)
            {
                return;
            }

            //������΂����������߂�(�v���C���[����G�ꂽ���̂̕���)
            Vector3 toVec = GetAngleVec(this.gameObject, collision.gameObject);

            //Y�����𑫂�
            toVec = toVec + new Vector3(0, 3, 0);

            //������΂�
            otherRigitbody.AddForce(toVec * impulse, ForceMode.Impulse);
            StartCoroutine("GetOut",collision.gameObject);
        }

        Vector3 GetAngleVec(GameObject _from, GameObject _to)
        {
            //�����̊T�O�����Ȃ��x�N�g�������
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