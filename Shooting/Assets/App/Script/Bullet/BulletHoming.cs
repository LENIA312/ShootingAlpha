using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Shooting.Bullet;

namespace Shooting
{
    public class BulletHoming : BulletBase
    {

        GameObject target = null;

        public void Setup(float speed,int attack)
        {
            base.Setup(speed,1,attack);

            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Enemy"))
            {

                target = target ?? obj;
                
                if(Vector2.Distance(this.transform.position,target.transform.position) >
                   Vector2.Distance(this.transform.position, obj.transform.position))
                {
                    target = obj;
                }

                Debug.Log($"{target.name}");
            }

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log($"call update homing");

            Move();
        }

        private void Move()
        {
            if (!target)
            {
                transform.position = new Vector2(
                transform.position.x,
                transform.position.y + speed * Time.deltaTime
                );
            }
            else
            {
                this.transform.position = Vector2.MoveTowards(
                    this.transform.position,
                    new Vector2(
                        target.transform.position.x,
                        target.transform.position.y
                    ), speed * Time.deltaTime);

                Observable.Interval(System.TimeSpan.FromSeconds(0.5))
                .Subscribe(_ =>
                {
                    speed *= 1.01f;
                });
            }
        }

        // ?????????
        void OnBecameInvisible()
        {
            Destroy(this.gameObject);
        }
    }
}
