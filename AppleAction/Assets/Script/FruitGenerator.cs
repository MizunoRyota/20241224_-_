using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    //prefab�Ɏg���I�u�W�F�N�g�𐶐�
    public GameObject Apple;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        //delta�Ɍo�ߎ��Ԃ�ǉ�
        this.delta += Time.deltaTime;
        //�P�b�o�߂�����A��𐶐�����
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
