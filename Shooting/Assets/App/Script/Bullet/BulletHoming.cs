using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    public class BulletHoming : BulletBase
    {

        public void Setup(float speed)
        {
            base.Setup(speed,1,1);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log($"call update homing");

            transform.position = new Vector2(
                transform.position.x,
                transform.position.y - speed
            );
        }
    }
}
