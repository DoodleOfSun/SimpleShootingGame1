using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float currentTime;   // ������ �� �ð�
    public float createTime;    // ���� ���۵Ǵ� �ð�
    public GameObject enemyFactory; // Enemy Prefab
    public float randomRangeFloat = 5;  // ���� ���۵Ǵ� �ð� ���� ����

    void Start()
    {
        currentTime = 0;
        createTime = UnityEngine.Random.Range(0,randomRangeFloat);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > createTime)
        {
            GameObject sponedEnemy = Instantiate(enemyFactory);
            sponedEnemy.transform.position = this.transform.position;
            createTime = UnityEngine.Random.Range(0, randomRangeFloat);
            currentTime = 0;
        }
    }
}