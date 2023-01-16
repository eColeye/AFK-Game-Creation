using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public static float cost = 1857520000000f;
    private static float initialCost = 1857520000000f;
    private static float costMulti = 1.07f;
    public static float initialRev = 1273290000000f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.wormLevel++;
            Up_Check(GameManager.wormLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.wormInter = GameManager.wormInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.wormInter = GameManager.wormInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.wormInter = GameManager.wormInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }
    private void Update_Cost() { cost = initialCost * (GameManager.wormLevel + 1) * Mathf.Pow(costMulti, GameManager.wormLevel - 1); }
    private void Update_Production() { GameManager.wormProduction = initialRev * GameManager.wormLevel; }
}
