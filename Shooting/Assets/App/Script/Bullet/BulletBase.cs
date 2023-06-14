using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    public class BulletBase : MonoBehaviour
    {
        protected float speed;
        protected int score;
        protected int attack;

        protected void Setup(float spd, int score, int attack)
        {
            this.speed = spd;
            this.score = score;
            this.attack = attack;
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            CommonHitAction(collision);
        }

        protected void CommonHitAction(Collider2D collision)
        {
            
            if (collision.transform.tag == "Enemy")
            {
                collision.TryGetComponent(out EnemyBase enemy);
                enemy.Attack(attack);

                Destroy(this.gameObject);
            }
        }
    }
}
