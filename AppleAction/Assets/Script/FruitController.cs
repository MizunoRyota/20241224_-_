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
    private void OnCollisionEnter(Collision collision) //�Ԃ�����������閽�ߕ��J�n
    {
        if (collision.gameObject.CompareTag("Fruit"))//����������Fruit�Ƃ����^�O������I�u�W�F�N�g����Ł`�Ƃ��������̉�
        {
            ScoreScript.instance.ScoreManager(point);
            transform.position = new Vector3(1, 4, -16);
        }

    }
}
