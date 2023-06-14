using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBase : MonoBehaviour
{
    private float speed;
    private int score;
    private int hp;
    Action<int> addScore;

    public void Setup(float speed,int score,int hp,Action<int> addScore)
    {
        this.speed = speed;
        this.score = score;
        this.hp = hp;
        this.addScore = addScore;

        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(int atk)
    {
        this.hp -= atk;
        if(hp <= 0)
        {
            addScore?.Invoke(score);
            Destroy(this.gameObject);
        }
    }
}
