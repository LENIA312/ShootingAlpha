using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    [System.Serializable]
    public class BulletBase : MonoBehaviour
    {
        protected float speed;
        protected int score;
        protected float interval;

        protected void Setup(float spd, int score, float interval)
        {
            this.speed = spd;
            this.score = score;
            this.interval = interval;
        }
    }
}
