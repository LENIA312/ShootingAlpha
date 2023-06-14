using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace Shooting
{
    public class SampleScene : MonoBehaviour
    {

        [SerializeField] PlayerBase player = default;
        [SerializeField] EnemyBase enemy = default;

        [SerializeField] Text scoreText = default;

         private int score;

        // Start is called before the first frame update
        void Start()
        {
            score = 0;
            // Display Score Update.
            scoreText.text = this.score.ToString();

            player.Setup();

            GenerateEnemy();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void GenerateEnemy()
        {
            Observable.Interval(System.TimeSpan.FromSeconds(1))
            .Subscribe(_ =>
            {
                var enemyObj = Instantiate(enemy);
                enemyObj.Setup(1, 1, 1, AddScore);
            });
        }

        void AddScore(int score)
        {
            this.score += score;

            // Display Score Update.
            scoreText.text = this.score.ToString();
        }
    }
}
