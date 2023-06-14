using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Shooting.Bullet;
using UniRx;

namespace Shooting
{
    public class BulletController : MonoBehaviour
    {
        [SerializeField] BulletHolder bulletHolder = default;

        private delegate void SetDelegate(BulletDefine.BulletData data,float spd);
        Dictionary<BulletDefine.BulletType, SetDelegate> delegateMethod;

        public void Setup()
        {
            SetupMethods();

            foreach (var bullet in bulletHolder.GetBulletData())
            {
                delegateMethod[bullet.type].Invoke(bullet,0.01f);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SetupMethods()
        {
            delegateMethod = new Dictionary<BulletDefine.BulletType, SetDelegate>
            {
                { BulletDefine.BulletType.Notmal,SetupNormal},
                { BulletDefine.BulletType.Homing,SetupHoming},
            };

        }

        /*** 弾のセットアップ関数 ***/

        // 通常弾
        void SetupNormal(BulletDefine.BulletData data, float spd)
        {
            Debug.Log($"Normal Bullet Setup");

            Observable.Interval(TimeSpan.FromSeconds(1))
             .Subscribe(_ =>
             {
                 var bullets = Instantiate(data.bullet,this.transform);
                 bullets.GetComponent<BulletNormal>().Setup(spd);
             });
        }

        // ホーミング弾
        void SetupHoming(BulletDefine.BulletData data, float spd)
        {
            Debug.Log($"Homing Bullet Setup");
           
            Observable.Interval(TimeSpan.FromSeconds(1))
            .Subscribe(_ =>
            {
                var bullets = Instantiate(data.bullet, this.transform);
                bullets.GetComponent<BulletHoming>().Setup(spd);
            });
        }


    }
}
