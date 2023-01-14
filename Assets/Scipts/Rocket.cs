using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public static float cost = 89579520f;
    private static float initialCost = 89579520f;
    private static float costMulti = 1.07f;
    public static float initialRev = 86967540f;

    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.rocketLevel++;
            Up_Check(GameManager.rocketLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.rocketInter = GameManager.rocketInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.rocketInter = GameManager.rocketInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.rocketInter = GameManager.rocketInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }

    private void Update_Cost() { cost = initialCost * (GameManager.rocketLevel + 1) * Mathf.Pow(costMulti, GameManager.rocketLevel - 1); }
    private void Update_Production() { GameManager.rocketProduction = initialRev * GameManager.rocketLevel; }
}
