﻿using CodeBase.Enemy;
using UnityEngine;

namespace CodeBase.Boosters
{
    public class DoubleDamageBooster : MonoBehaviour
    {
        private void Awake() => 
            GetComponent<EnemyDeath>().Happened += OnDoubleDamage;

        private void OnDoubleDamage(GameObject obj)
        {
            GameObject.FindWithTag("DoubleDamage").GetComponent<BoosterEffect>().Activate(5f);
            Destroy(gameObject);
        }
    }
}