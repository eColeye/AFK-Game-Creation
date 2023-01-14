using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public static float cost = 622080f;
    private static float initialCost = 622080f;
    private static float costMulti = 1.07f;
    public static float initialRev = 718740f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.truckLevel++;
            Up_Check(GameManager.truckLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.truckInter = GameManager.truckInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.truckInter = GameManager.truckInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.truckInter = GameManager.truckInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }

    private void Update_Cost() { cost = initialCost * (GameManager.truckLevel + 1) * Mathf.Pow(costMulti, GameManager.truckLevel - 1); }
    private void Update_Production() { GameManager.truckProduction = initialRev * GameManager.truckLevel; }
}
