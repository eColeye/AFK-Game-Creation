using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{

    //Texts
    public Text T1;
    public Text T2;
    public Text T3;
    public Text T4;
    public Text T5;
    public Text T6;
    public Text T7;
    public Text T8;
    public Text T9;
    public Text T10;
    public Text T11;
    public Text T12;

    //Buttons
    public GameObject U1;
    public GameObject U2;
    public GameObject U3;
    public GameObject U4;
    public GameObject U5;
    public GameObject U6;
    public GameObject U7;
    public GameObject U8;
    public GameObject U9;
    public GameObject U10;
    public GameObject U11;
    public GameObject U12;

    public GameObject[] U;

    //Strings
    private static string[] strings = { 
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12"
    };

    //Other
    public static int bought = 0;

    public void Upgrade(int key)
    {
        int count = 0;
        for(int i = 1; count < key; i++)
        {
            if (strings[i] != "NULL"){count++;}
            if(count == key)
            {
                switch(i)
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
        }
    }

    private void Start()
    {
        Refresh();
    }

    public void Up1()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up2()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up3()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up4()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up5()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up6()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up7()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up8()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up9()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up10()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up11()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }
    public void Up12()
    {
        //Upgrade Miner
        Miner.initialRev = Miner.initialRev * 6;
        strings[0] = "NULL";
        bought++;
    }

    private void Refresh()
    {
        for(int i = 1 ; i <= (12 - bought); i++)
        {
            int found = 0; 
            switch(i)
            {
                //assign text to each upgrade.
                case 1:
                    for(int temp = 0; found <= i; temp++) 
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if(found == i)
                            {
                                T1.text = strings[temp]; 
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T2.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 3:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T3.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 4:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T4.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 5:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T5.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 6:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T6.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 7:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T7.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 8:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T8.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 9:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T9.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 10:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T10.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 11:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T11.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
                case 12:
                    for (int temp = 0; found <= i; temp++)
                    {
                        if (strings[temp] != "NULL")
                        {
                            found++;
                            if (found == i)
                            {
                                T12.text = strings[temp];
                                break;
                            }
                        }
                    }
                    break;
            }
        }
        for(int i = 1; i <= bought; i++)
        {
            switch (i)
            {
                case 1:
                    U12.SetActive(false);
                    break;
                case 2:
                    U11.SetActive(false);
                    break;
                case 3:
                    U10.SetActive(false);
                    break;
                case 4:
                    U9.SetActive(false);
                    break;
                case 5:
                    U8.SetActive(false);
                    break;
                case 6:
                    U7.SetActive(false);
                    break;
                case 7:
                    U6.SetActive(false);
                    break;
                case 8:
                    U5.SetActive(false);
                    break;
                case 9:
                    U4.SetActive(false);
                    break;
                case 10:
                    U3.SetActive(false);
                    break;
                case 11:
                    U2.SetActive(false);
                    break;
                case 12:
                    U1.SetActive(false);
                    break;
            }
        }
    }

    /*
        for(int i = 1 ; i <= (12 - bought); i++)
            {
                switch(i)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                }
            }



    */
}   
