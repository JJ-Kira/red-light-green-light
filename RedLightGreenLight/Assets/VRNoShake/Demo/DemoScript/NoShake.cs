using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoShake : MonoBehaviour
{
    [Range(0, 20f)]
    public float MaxPositionV = 2f;//�ٶ�ƽ�����ֵ����ֵԽ������Խ��Խ�����֣�Ĭ��Ϊ2
    [Range(0, 1000f)]
    public float MaxRotationV = 100f;//���ٶ�ƽ�����ֵ����ֵԽ������Խ��Խ�����֣�Ĭ��Ϊ100
}
