using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    //prefabに使うオブジェクトを生成
    public GameObject Apple;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        //deltaに経過時間を追加
        this.delta += Time.deltaTime;
        //１秒経過したら、矢を生成する
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Apple);
            int px = Random.Range(-4, 5);
            int pz= Random.Range(-27, -22);
            go.transform.position = new Vector3(px, 10, pz);

        }

    }
}
