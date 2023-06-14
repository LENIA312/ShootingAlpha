using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting.Bullet;

namespace Shooting
{
    public class BulletNormal : BulletBase
    {
        public void Setup(float speed, int attack)
        {
            base.Setup(speed, 1,attack);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log($"call update normal");

            transform.position = new Vector2(
                transform.position.x,
                transform.position.y + speed * Time.deltaTime
            );
        }

        // 画面外に出たら消す
        void OnBecameInvisible()
        {
            Destroy(this.gameObject);
        }
    }
}
