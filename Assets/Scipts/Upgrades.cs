using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public Text[] T;
    public GameObject[] U;

    //Upgrades
    private float[] C =
{
        250000f,
        500000f,
        1000000f,
        2500000f,
        5000000f,
        15000000f,
        400000000f,
        4200000000f,
        50000000000f,
        500000000000f,
        5000000000000f,
        50000000000000f,
    };
    private string[] S = { 
        "Miner profit x3\n",
        "Drill profit x3\n",
        "Car profit x3\n",
        "Granade profit x3\n",
        "Coal Mine profit x3\n",
        "UHaul Truck profit x3\n",
        "TnT profit x3\n",
        "Rocket Ship profit x3\n",
        "Nuke profit x3\n",
        "UFO profit x3\n",
        "BlackHole profit x3\n",
        "WormHole profit x3\n"
    };

    //Other
    public int bought = 0;

    private void Start()
    {
        for(int i = 0; i < 12; i++)
        {
            S[i] = S[i] + "$" + (MoneyCalc(C[i])).ToString();
        }
        Refresh();
    }

    public void Upgrade(int key)
    {
        int find = Find(key);
        if (!GameManager.Has_Money(C[find]))
        {
            return;
        }
        GameManager.Spend(C[find]);
        switch ((find +1))
        {
            case 1:
                Up1();
                Refresh();
                return;
            case 2:
                Up2();
                Refresh();
                return;
            case 3:
                Up3();
                Refresh();
                return;
            case 4:
                Up4();
                Refresh();
                return;
            case 5:
                Up5();
                Refresh();
                return;
            case 6:
                Up6();
                Refresh();
                return;
            case 7:
                Up7();
                Refresh();
                return;
            case 8:
                Up8();
                Refresh();
                return;
            case 9:
                Up9();
                Refresh();
                return;
            case 10:
                Up10();
                Refresh();
                return;
            case 11:
                Up11();
                Refresh();
                return;
            case 12:
                Up12();
                Refresh();
                return;
        }
    }

    public int Find(int key)
    {
        int f = 0;
        for(int i = 0; i <= 11; i++)
        {
            if(S[i] != "NULL")
            {
                f++;
            }
            if(f == key) 
            {
                return i;
            }
        }
        return -1;
    }

    public void Up1()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[0] = "NULL";
        bought++;
    }
    public void Up2()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[1] = "NULL";
        bought++;
    }
    public void Up3()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[2] = "NULL";
        bought++;
    }
    public void Up4()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[3] = "NULL";
        bought++;
    }
    public void Up5()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[4] = "NULL";
        bought++;
    }
    public void Up6()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[5] = "NULL";
        bought++;
    }
    public void Up7()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[6] = "NULL";
        bought++;
    }
    public void Up8()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[7] = "NULL";
        bought++;
    }
    public void Up9()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[8] = "NULL";
        bought++;
    }
    public void Up10()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[9] = "NULL";
        bought++;
    }
    public void Up11()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[10] = "NULL";
        bought++;
    }
    public void Up12()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        S[11] = "NULL";
        bought++;
    }

    private void Refresh()
    {
        int found = 0;
        for(int i = 0; i <= (11); i++)
        {
            if (S[i] != "NULL")
            {
                T[found].text = S[i];
                found++;
            }        
        }

        //deactivating button
        if(bought > 0)
        {
            U[12 - bought].SetActive(false);
        }
    }

    public string MoneyCalc(float cost)
    {
        string tempMoney = cost.ToString("F0");
        if (tempMoney.Length > 7)
        {
            return tempMoney[0] + "." + tempMoney.Substring(1, 3) + "x10^" + (tempMoney.Length - 1);
        }
        else if (tempMoney.Length > 6)
        {
            return tempMoney[0] + "," + tempMoney.Substring(1, 3) + "," + tempMoney.Substring(+4);
        }
        return tempMoney;
    }
}
