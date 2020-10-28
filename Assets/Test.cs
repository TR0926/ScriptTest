using System.Collections;
using UnityEditorInternal;
using UnityEngine;

public class Boss
{
    private int hp = 100;  //体力
    private int power = 25;  //攻撃力
    private int mp = 53;  //MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与える");
    }

    // 防御用の関数
    public void Defence(int damege)
    {
        Debug.Log(damege + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damege;
    }
    // 魔法攻撃用の関数
    public void Magic()
    {
        //mpが5以上ならmpを5減らして魔法攻撃
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        // mpが5以下なら魔法攻撃できない
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        // 配列の各要素を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        // 配列の各要素を逆順に表示
        for (int ii = array.Length - 1; ii >= 0; ii--)
        {
            Debug.Log(array[ii]);
        }
        //  Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // Magic関数を10回使用する
        for(int mattack = 0; mattack < 10; mattack++)
        {
            lastboss.Magic();
        }
        // もう一度Magic関数を呼び出す
        lastboss.Magic();

    }

    //Update is called once per frame
    void Update()
    {

    }
}