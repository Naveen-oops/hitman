﻿using UnityEngine;
using Common;
using Zenject;
using System.Collections;

namespace Enemy
{
    public interface IEnemyService
    {
        
        void SpawnEnemy(EnemyScriptableObjectList enemyScriptableObject);
        void PerformMovement();
        int GetPlayerNodeID();
        void TriggerPlayerDeath();
        bool CheckForEnemyPresence(int playerNodeID);
    }
}
