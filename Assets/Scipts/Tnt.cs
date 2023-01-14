using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tnt : MonoBehaviour
{
    public static float cost = 7464960f;
    private static float initialCost = 7464960f;
    private static float costMulti = 1.07f;
    public static float initialRev = 7906140f;


    public void Upgrade()
    {
        if (GameManager.Has_Money(cost))
        {
            GameManager.Spend(cost);
            GameManager.tntLevel++;
            Up_Check(GameManager.tntLevel);
            Update_Cost();
            Update_Production();
        }
    }
    private void Up_Check(int lvl)
    {
        switch (lvl)
        {
            case 15:
                GameManager.tntInter = GameManager.tntInter / 2f;
                return;
            case 30:
                initialRev = initialRev * 2;
                Update_Production();
                return;
            case 50:
                GameManager.tntInter = GameManager.tntInter / 2f;
                return;
            case 69:
                initialRev = initialRev * 3;
                Update_Production();
                return;
            case 80:
                GameManager.tntInter = GameManager.tntInter / 2f;
                return;
            case 100:
                initialRev = initialRev * 4;
                Update_Production();
                return;
            default: return;
        }
    }
    private void Update_Cost() { cost = initialCost * (GameManager.tntLevel + 1) * Mathf.Pow(costMulti, GameManager.tntLevel - 1); }
    private void Update_Production() { GameManager.tntProduction = initialRev * GameManager.tntLevel; }
}
