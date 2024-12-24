using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    public float DestroyTime;
    public int point = 10;

    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        DestroyTime = 3.0f;
        elapsedTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision) //ぶつかったら消える命令文開始
    {
        if (collision.gameObject.CompareTag("Fruit"))//さっきつけたFruitというタグがあるオブジェクト限定で～という条件の下
        {
            ScoreScript.instance.ScoreManager(point);
            transform.position = new Vector3(1, 4, -16);
        }

    }
}
