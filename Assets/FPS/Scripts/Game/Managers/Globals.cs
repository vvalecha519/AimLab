using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    // level 1 = easy
    // level 2 = medium
    // level 3 = hard
    public static int level = 1;
    public static int targetsDestroyed;
    public static int bulletsFired;
    public static float size;
    public static float speed;
    public static float spawnRate;
    public static float targetLife;

    public static readonly DifficultySettings easySetting = new DifficultySettings(2, 1.5, 20, 0);
    public static readonly DifficultySettings mediumSetting = new DifficultySettings(0.9, 0.9, 5, 1);
    public static readonly DifficultySettings hardSetting = new DifficultySettings(0.65, 0.75, 3, 2);
    public static DifficultySettings mSetting  = new DifficultySettings(0.65, 0.75, 3, 2);

    public static DifficultySettings getDifficultySettings()
    {
        //if (level == 1) return easySetting;
        //if (level == 2) return mediumSetting;
        //else return hardSetting;
        Debug.Log(speed);
        Debug.Log(size);

        mSetting.MoveSpeed = speed;
        mSetting.TargetLife = targetLife;
        mSetting.SpawnRate = spawnRate;
        mSetting.SizeMultiplier = size;
        return mSetting;
    }


    public class DifficultySettings
    {
        public double SizeMultiplier;
        public double SpawnRate;
        public float TargetLife;
        public float MoveSpeed;

        public DifficultySettings(double sizeMultiplier, double spawnRate, int targetLife, int moveSpeed)
        {
            SizeMultiplier = sizeMultiplier;
            SpawnRate = spawnRate;
            TargetLife = targetLife;
            MoveSpeed = moveSpeed;
        }
    }


}
