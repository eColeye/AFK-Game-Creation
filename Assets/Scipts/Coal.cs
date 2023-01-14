using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coal : MonoBehaviour
{
    public static float cost = 51840f;
    private static float initialCost = 51840f;
    private static float costMulti = 1.07f;
    public static float initialRev = 65340f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.coalLevel++;
            Up_Check(GameManager.coalLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.coalInter = GameManager.coalInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.coalInter = GameManager.coalInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.coalInter = GameManager.coalInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }

    private void Update_Cost() { cost = initialCost * (GameManager.coalLevel + 1) * Mathf.Pow(costMulti, GameManager.coalLevel - 1); }
    private void Update_Production() { GameManager.coalProduction = initialRev * GameManager.coalLevel; }
}