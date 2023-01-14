using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    public static float cost = 4320f;
    private static float initialCost = 4320f;
    private static float costMulti = 1.07f;
    public static float initialRev = 5940f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.granadeLevel++;
            Up_Check(GameManager.granadeLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.granadeInter = GameManager.granadeInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.granadeInter = GameManager.granadeInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.granadeInter = GameManager.granadeInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }

    private void Update_Cost() { cost = initialCost * (GameManager.granadeLevel + 1) * Mathf.Pow(costMulti, GameManager.granadeLevel - 1); }
    private void Update_Production() { GameManager.granadeProduction = initialRev * GameManager.granadeLevel; }
}
