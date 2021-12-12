using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject explosionEffect;
    public float enemySpeed = 3;
    public float enemyChasePlayerCase;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        enemyChasePlayerCase = UnityEngine.Random.Range(0,10);
        if (enemyChasePlayerCase > 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - this.transform.position;
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += dir * enemySpeed * Time.deltaTime;
        dir.Normalize();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject calledScoreManager = GameObject.Find("ScoreManager");
        ScoreManager sm = calledScoreManager.GetComponent<ScoreManager>();
        sm.setScore(sm.getScore() + 1);

        GameObject explosion = Instantiate(explosionEffect);
        explosion.transform.position = this.transform.position;
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}