using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public static float cost = 360f;
    private static float initialCost = 360f;
    private static float costMulti = 1.07f;
    public static float initialRev = 540f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.carLevel++;
            Up_Check(GameManager.carLevel);
            Update_Cost();
            Update_Production();
        }
    }

    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.carInter = GameManager.carInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.carInter = GameManager.carInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.carInter = GameManager.carInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }
    public static void Refresh(){Update_Cost();Update_Production();}
    private static void Update_Cost() { cost = initialCost * (GameManager.carLevel + 1) * Mathf.Pow(costMulti, GameManager.carLevel - 1); }
    private static void Update_Production() { GameManager.carProduction = initialRev * GameManager.carLevel; }
}
