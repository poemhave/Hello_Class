using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // ������ ���Ѻ���
    public string name;
    public string sound;

    // �����Ҹ��� ����ϴ� �޼���
    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}
