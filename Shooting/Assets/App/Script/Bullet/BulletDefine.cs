using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting.Bullet
{
    public class BulletDefine
    {
        public enum BulletType
        {
            Notmal, // 通常弾
            Homing, // ホーミング弾(1番近い敵に)
        }

        [System.Serializable]
        public class BulletData
        {
            public BulletBase bullet;
            public BulletType type;
            public string act;
        }
    }
}