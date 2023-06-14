using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    public class PlayerBase : MonoBehaviour
    {
        [SerializeField] BulletController bullet = default;

        // 非タップ時は移動しないのでflgはfalse
        private bool moveFlg = true;

        private bool onBullet = true;

        public void Setup()
        {
            bullet.Setup();
        }

        // Update is called once per frame
        void Update()
        {
            Move();
        }

        private void Move()
        {
            if (!moveFlg)
            {
                return;
            }

            if (Input.GetMouseButton(0))
            {
                // タップした座標を取得
                Vector3 tapPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,0,10f));

                // オブジェクトのX座標をタップした座標のX座標に設定
                transform.position = new Vector3(tapPosition.x, transform.position.y, tapPosition.z);
            }
        }

    }
}
