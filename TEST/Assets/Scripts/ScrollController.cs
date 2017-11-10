using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System.Collections;

public class ScrollController : MonoBehaviour
{
    
    [SerializeField]
    RectTransform prefab = null;

    // 文字列を保持するための変数を作成する
    string mojiretu;

    private float waitingTime = 2.0f;
    /*2
    public GameObject Node;
    public GameObject instance;
    */

    //3 public GameObject Obj;

    string[] values;


    void Awake()
    {
        InvokeRepeating("Start", waitingTime,waitingTime);
        //InvokeRepeating("Update", waitingTime, waitingTime);
    }
    
    void Start()
    {
        //CSVファイルの読み込み
        TextAsset csv = Resources.Load("CSV/DX") as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {
            // 文字列データを取り出す
            string line = reader.ReadLine();
            string[] values = line.Split('\n');
            Debug.Log(line);


            string moji = (values).ToString();

            // 取り出した文字を格納する(上で宣言した変数の中に入れる)

            string mojiretu = moji;
        }

        // 格納した文字列の数をつかってfor文回す
        
        for (int i = 0; i < mojiretu.Length;  i++)
        {

        var item = GameObject.Instantiate(prefab) as RectTransform;
        item.SetParent(transform, false);

        var text = item.GetComponentInChildren<Text>();
            //text.text = "item:" + i.ToString();
            // text.text = values[0];

            // textにたいして、格納した文字列を設定する

            text.text = mojiretu;
                            
        }
    }
}

