using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting.Bullet;
using Shooting;

namespace Shooting
{
    [CreateAssetMenu(fileName = "BulletHolder", menuName = "Holder/BulletHolder")]
    public class BulletHolder : ScriptableObject
    {
        [SerializeField] List<BulletDefine.BulletData> datas;

        public List<BulletDefine.BulletData> GetBulletData()
        {           
            return datas;
        }
    }
}

