using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{

    private int mp = 53;   //int�^�̕ϐ�mp��錾���A53�ŏ�����



    //mp������Ė��@�U��������Magic�֐�
    public void Magic()
    {

        if (this.mp >=5)
        {
            //mp��5�ȏ�̏ꍇ��5���炵�A�R���\�[���ɕ\��
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }
        else
        {
            //mp������Ȃ��ꍇ
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }

    }



}


public class Test : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {

        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ�����
        int[] array = { 1, 2, 3, 4, 5 };

        // for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\��
        for (int i = 0; i < array.Length; i++)
        {

            // �z��̗v�f��\������
            Debug.Log(array[i]);

        }

        // for�����g���A�z��̊e�v�f�̒l���t���ɕ\��
        for (int j = 4; j >= 0; j--)
        {

            // �z��̗v�f��\������
            Debug.Log(array[j]);

        }



        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();


        // 11�񏈗����J��Ԃ�
        for (int k = 0; k < 11; k++)
        {
            //���@�U���p�̊֐����Ăяo��
            lastboss.Magic();

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
