using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float currentTime;   // 프레임 당 시간
    public float createTime;    // 적이 제작되는 시간
    public GameObject enemyFactory; // Enemy Prefab
    public float randomRangeFloat = 5;  // 적이 제작되는 시간 랜덤 범위

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