using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    public class SampleScene : MonoBehaviour
    {

        [SerializeField] PlayerBase player = default;

        // Start is called before the first frame update
        void Start()
        {
            player.Setup();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
