using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    [System.Serializable]
    public class BulletNormal : BulletBase
    {

        public void Setup(float speed)
        {
            base.Setup(speed,1,1);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log($"call update normal");

            transform.position = new Vector2(
                transform.position.x,
                transform.position.y + speed
            );
        }
    }
}
