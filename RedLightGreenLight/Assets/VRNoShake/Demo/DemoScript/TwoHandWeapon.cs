using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandWeapon : MonoBehaviour
{

    public Transform LeftHandSource, RightHandSource;//������Դ,���ڻ����������


    //���˲�֮����²�ֵλ��
    private void LateUpdate()
    {
        if (gameObject.activeSelf)
        {
            //ǹ����ȷ����˫����������
            Vector3 TwoHandForward = (LeftHandSource.position - RightHandSource.position).normalized;//ȡ�÷�������
            transform.forward = Vector3.Lerp(transform.forward, TwoHandForward, 0.1f); //���ֳ���������Ϊ��������,��ֵʵ��,0.1����ΪLerp�����Ҳ�ڲ��ϱ仯��˳��ʵ���˲�ֵ
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, RightHandSource.eulerAngles.z);//����Z�ᡣ
        }
        
    }
}
