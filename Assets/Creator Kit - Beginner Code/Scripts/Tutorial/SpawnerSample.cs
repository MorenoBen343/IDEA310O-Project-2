﻿using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngle myLootAngle = new LootAngle(45);
        spawnHealthPot(myLootAngle.NextAngle());
        spawnHealthPot(myLootAngle.NextAngle());
        spawnHealthPot(myLootAngle.NextAngle());
        spawnHealthPot(myLootAngle.NextAngle());
    }

    void spawnHealthPot(int angle) {
        int radius = 5;
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle {
    
    int angle;
    int step;

    public LootAngle(int increment) {
        step = increment;
        angle = 0;
    }
    
    public int NextAngle() {
        int currAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currAngle;
    }
}


