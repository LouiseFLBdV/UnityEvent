using System.Collections.Generic;
using UnityEngine;

namespace Shared
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject objectForSpawn;
        [SerializeField] private List<Transform> spawnPoints;
        
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
