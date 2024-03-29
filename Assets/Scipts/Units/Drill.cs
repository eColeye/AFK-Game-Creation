using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public static float cost = 30f;
    private static float initialCost = 30f;
    private static float costMulti = 1.07f;
    public static float initialRev = 60f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.drillLevel++;
            Up_Check(GameManager.drillLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.drillInter = GameManager.drillInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.drillInter = GameManager.drillInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.drillInter = GameManager.drillInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }
    public static void Refresh(){Update_Cost();Update_Production();}
    private static void Update_Cost() { cost = initialCost * (GameManager.drillLevel + 1) * Mathf.Pow(costMulti, GameManager.drillLevel - 1); }
    private static void Update_Production() { GameManager.drillProduction = initialRev * GameManager.drillLevel; }
}