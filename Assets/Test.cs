using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{

    private int mp = 53;   //int型の変数mpを宣言し、53で初期化



    //mpを消費して魔法攻撃をするMagic関数
    public void Magic()
    {

        if (this.mp >=5)
        {
            //mpを5以上の場合は5減らし、コンソールに表示
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            //mpが足りない場合
            Debug.Log("MPが足りないため、魔法が使えない。");
        }

    }



}


public class Test : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 1, 2, 3, 4, 5 };

        // for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++)
        {

            // 配列の要素を表示する
            Debug.Log(array[i]);

        }

        // for文を使い、配列の各要素の値を逆順に表示
        for (int j = 4; j >= 0; j--)
        {

            // 配列の要素を表示する
            Debug.Log(array[j]);

        }



        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();


        // 11回処理を繰り返す
        for (int k = 0; k < 11; k++)
        {
            //魔法攻撃用の関数を呼び出す
            lastboss.Magic();

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
