using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo : MonoBehaviour
{
    public static float cost = 12899450880f;
    private static float initialCost = 12899450880f;
    private static float costMulti = 1.07f;
    public static float initialRev = 10523072340f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.ufoLevel++;
            Up_Check(GameManager.ufoLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.ufoInter = GameManager.ufoInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.ufoInter = GameManager.ufoInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.ufoInter = GameManager.ufoInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }

    private void Update_Cost() { cost = initialCost * (GameManager.ufoLevel + 1) * Mathf.Pow(costMulti, GameManager.ufoLevel - 1); }
    private void Update_Production() { GameManager.ufoProduction = initialRev * GameManager.ufoLevel; }
}
