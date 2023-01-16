using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Money
    public Text moneyText;
    private string tempMoney;
    private static float money = 10000000f;

    //lvl incs
    //lvl 15 time / 2
    //lvl 30 make * 2
    //lvl 45 time / 2
    //lvl 60 make *2
    //lvl 69 time / 2 
    //lvl 100 make * 4

    //abilities:
    //rev  * 2      ??
    //cost / 2      ??

    //help
    /*Shows what upgrades you get per lvl inc,
     * 
    */

    //Miner 1
    public Text minerText;
    public static int minerLevel = 1;
    public static float minerProduction = Miner.initialRev;
    public static float minerInter = 0.6f;
    public static float minerTime = 0f;

    //Drill 2
    public Text drillText;
    public static int drillLevel = 0;
    public static float drillProduction = Drill.initialRev;
    public static float drillInter = (3 * 1);
    public static float drillTime = 0f;

    //Car 3
    public Text carText;
    public static int carLevel = 0;
    public static float carProduction = Car.initialRev;
    public static float carInter = (3 * 2);
    public static float carTime = 0f;

    //Granade 4
    public Text granadeText;
    public static int granadeLevel = 0;
    public static float granadeProduction = Granade.initialRev;
    public static float granadeInter = (3 * 4);
    public static float granadeTime = 0f;

    //Coal Mine 5
    public Text coalText;
    public static int coalLevel = 0;
    public static float coalProduction = Coal.initialRev;
    public static float coalInter = (3 * 8);
    public static float coalTime = 0f;

    //Truck 6
    public Text truckText;
    public static int truckLevel = 0;
    public static float truckProduction = Truck.initialRev;
    public static float truckInter = (3 * 16);
    public static float truckTime = 0f;

    //TnT
    public Text tntText;
    public static int tntLevel = 0;
    public static float tntProduction = Tnt.initialRev;
    public static float tntInter = (3 * 32);
    public static float tntTime = 0f;

    //Rocket
    public Text rocketText;
    public static int rocketLevel = 0;
    public static float rocketProduction = Rocket.initialRev;
    public static float rocketInter = (3 * 64);
    public static float rocketTime = 0f;

    //Nuke
    public Text nukeText;
    public static int nukeLevel = 0;
    public static float nukeProduction = Nuke.initialRev;
    public static float nukeInter = (3 * 128);
    public static float nukeTime = 0f;

    //UFO
    public Text ufoText;
    public static int ufoLevel = 0;
    public static float ufoProduction = Ufo.initialRev;
    public static float ufoInter = (3 * 256);
    public static float ufoTime = 0f;

    //BlackHole
    public Text blackText;
    public static int blackLevel = 0;
    public static float blackProduction = Black.initialRev;
    public static float blackInter = (3 * 512);
    public static float blackTime = 0f;

    //WormHole
    public Text wormText;
    public static int wormLevel = 0;
    public static float wormProduction = Worm.initialRev;
    public static float wormInter = (3 * 1024);
    public static float wormTime = 0f;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //time increments
        float time = Time.deltaTime;

        //miner
        if (minerLevel > 0)
        {
            minerTime += time;
            miner();
            minerText.text = "Miner Lvl " + minerLevel + "\nProduction " + minerProduction + "  " + TimeCalc(minerInter - minerTime) + "\nUpgrade Cost: " + MoneyCalc(Miner.cost);
        }

        //drill
        if (drillLevel > 0)
        {
            drill();
            drillTime += time;
            drillText.text = "Drill Lvl " + drillLevel + "\nProduction " + MoneyCalc(drillProduction) + "  " + TimeCalc(drillInter - drillTime) + "\nUpgrade Cost: " + MoneyCalc(Drill.cost);
        }else{
            drillText.text = "Drill Lvl " + drillLevel + "\nProduction " + MoneyCalc(drillProduction) + "  " + TimeCalc(drillInter) + "\nBuy Cost: " + MoneyCalc(Drill.cost);
        }

        //car
        if(carLevel > 0)
        {
            car();
            carTime += time;
            carText.text = "Car Lvl " + carLevel + "\nProduction " + MoneyCalc(carProduction) + "  " + TimeCalc(carInter - carTime) + "\nUpgrade Cost: " + MoneyCalc(Car.cost);
        }else{
            carText.text = "Car Lvl " + carLevel + "\nProduction " + MoneyCalc(carProduction) + "  " + TimeCalc(carInter) + "\nBuy Cost: " + MoneyCalc(Car.cost);
        }

        //Granade
        if (granadeLevel > 0)
        {
            granade();
            granadeTime += time;
            granadeText.text = "Granade Lvl " + granadeLevel + "\nProduction " + MoneyCalc(granadeProduction) + "  " + TimeCalc(granadeInter - granadeTime) + "\nUpgrade Cost: " + MoneyCalc(Granade.cost);
        }else{
            granadeText.text = "Granade Lvl " + granadeLevel + "\nProduction " + MoneyCalc(granadeProduction) + "  " + TimeCalc(granadeInter) + "\nBuy Cost: " + MoneyCalc(Granade.cost);
        }

        //coal
        if (coalLevel > 0)
        {
            coal();
            coalTime += time;
            coalText.text = "Coal Mine Lvl " + coalLevel + "\nProduction " + MoneyCalc(coalProduction) + "  " + TimeCalc(coalInter - coalTime) + "\nUpgrade Cost: " + MoneyCalc(Coal.cost); ;
        }
        else
        {
            coalText.text = "Coal Mine Lvl " + coalLevel + "\nProduction " + MoneyCalc(coalProduction) + "  " + TimeCalc(coalInter) + "\nBuy Cost: " + MoneyCalc(Coal.cost); ;
        }


        //truck
        if (truckLevel > 0)
        {
            truck();
            truckTime += time;
            truckText.text = "UHaul Truck Lvl " + truckLevel + "\nProduction " + MoneyCalc(truckProduction) + "  " + TimeCalc(truckInter - truckTime) + "\nUpgrade Cost: " + MoneyCalc(Truck.cost);
        }
        else
        {
            truckText.text = "UHaul Truck Lvl " + truckLevel + "\nProduction " + MoneyCalc(truckProduction) + "  " + TimeCalc(truckInter) + "\nBuy Cost: " + MoneyCalc(Truck.cost); ;
        }

        //tnt
        if (tntLevel > 0)
        {
            tnt();
            tntTime += time;
            tntText.text = "TnT Lvl " + tntLevel + "\nProduction " + MoneyCalc(tntProduction) + "  " + TimeCalc(tntInter - tntTime) + "\nUpgrade Cost: " + MoneyCalc(Tnt.cost);
        }
        else
        {
            tntText.text = "TnT Lvl " + tntLevel + "\nProduction " + MoneyCalc(tntProduction) + "  " + TimeCalc(tntInter) + "\nBuy Cost: " + MoneyCalc(Tnt.cost);
        }

        //rocket
        if (rocketLevel > 0)
        {
            rocket();
            rocketTime += time;
            rocketText.text = "Rocket Lvl " + rocketLevel + "\nProduction " + MoneyCalc(rocketProduction) + "  " + TimeCalc(rocketInter - rocketTime) + "\nUpgrade Cost: " + MoneyCalc(Rocket.cost);
        }
        else
        {
            rocketText.text = "Rocket Lvl " + rocketLevel + "\nProduction " + MoneyCalc(rocketProduction) + "  " + TimeCalc(rocketInter) + "\nBuy Cost: " + MoneyCalc(Rocket.cost);
        }

        //nuke
        if (nukeLevel > 0)
        {
            nuke();
            nukeTime += time;
            nukeText.text = "Nuke Lvl " + nukeLevel + "\nProduction " + MoneyCalc(nukeProduction) + "  " + TimeCalc(nukeInter - nukeTime) + "\nUpgrade Cost: " + MoneyCalc(Nuke.cost);
        }
        else
        {
            nukeText.text = "Nuke Lvl " + nukeLevel + "\nProduction " + MoneyCalc(nukeProduction) + "  " + TimeCalc(nukeInter) + "\nBuy Cost: " + MoneyCalc(Nuke.cost);
        }

        //ufo
        if (ufoLevel > 0)
        {
            ufo();
            ufoTime += time;
            ufoText.text = "UFO Lvl " + ufoLevel + "\nProduction " + MoneyCalc(ufoProduction) + "  " + TimeCalc(ufoInter - ufoTime) + "\nUpgrade Cost: " + MoneyCalc(Ufo.cost);
        }
        else
        {
            ufoText.text = "UFO Lvl " + ufoLevel + "\nProduction " + MoneyCalc(ufoProduction) + "  " + TimeCalc(ufoInter) + "\nBuy Cost: " + MoneyCalc(Ufo.cost);
        }

        //blackhole
        if (blackLevel > 0)
        {
            black();
            blackTime += time;
            blackText.text = "BlackHole Lvl " + blackLevel + "\nProduction " + MoneyCalc(blackProduction) + "  " + TimeCalc(blackInter - blackTime) + "\nUpgrade Cost: " + MoneyCalc(Black.cost);
        }
        else
        {
            blackText.text = "BlackHole Lvl " + blackLevel + "\nProduction " + MoneyCalc(blackProduction) + "  " + TimeCalc(blackInter) + "\nBuy Cost: " + MoneyCalc(Black.cost);
        }

        //wormhole
        if (wormLevel > 0)
        {
            worm();
            wormTime += time;
            wormText.text = "WormHole Lvl " + wormLevel + "\nProduction " + MoneyCalc(wormProduction) + "  " + TimeCalc(wormInter - wormTime) + "\nUpgrade Cost: " + MoneyCalc(Worm.cost);
        }
        else
        {
            wormText.text = "WormHole Lvl " + wormLevel + "\nProduction " + MoneyCalc(wormProduction) + "  " + TimeCalc(wormInter) + "\nBuy Cost: " + MoneyCalc(Worm.cost);
        }

        moneyText.text = "$" + MoneyCalc(money);
    }


    //money code
    public static void Spend(float cost){money -= cost;}
    public static bool Has_Money(float cost)
    {
        if(cost < money){return true;}
        return false;
    }

    public string MoneyCalc(float cost)
    {
        tempMoney = cost.ToString("F0");
        if(tempMoney.Length > 7)
        {
            return tempMoney[0] + "." + tempMoney.Substring(1, 3) + "x10^" + (tempMoney.Length - 1);
        }
        else if(tempMoney.Length > 6)
        {
            return tempMoney[0] + "," + tempMoney.Substring(1, 3) + "," + tempMoney.Substring(+4);
        }
        return tempMoney;
    }

    public string TimeCalc(float time)
    {
        if(time > 60)
        {
            if(time % 60 < 10)
            {
                return (time / 60).ToString("F0") + ":0" + (time % 60).ToString("F0");
            }
            else
            {
                return (time / 60).ToString("F0") + ":" + (time % 60).ToString("F0");
            }
        }
        return time.ToString("F1"); 
    }

    //Units
    private void miner()
    {
        if (minerTime > minerInter)
        {
            money += minerProduction;
            minerTime = 0;
        }
    }
    private void drill()
    {
        if (drillTime > drillInter)
        {
            money += drillProduction;
            drillTime = 0;
        }
    }
    private void car()
    {
        if (carTime > carInter)
        {
            money += carProduction;
            carTime = 0;
        }
    }
    private void granade()
    {
        if (granadeTime > granadeInter)
        {
            money += granadeProduction;
            granadeTime = 0;
        }
    }
    private void coal()
    {
        if (coalTime > coalInter)
        {
            money += coalProduction;
            coalTime = 0;
        }
    }
    private void truck()
    {
        if (truckTime > truckInter)
        {
            money += truckProduction;
            truckTime = 0;
        }
    }
    private void tnt()
    {
        if (tntTime > tntInter)
        {
            money += tntProduction;
            tntTime = 0;
        }
    }
    private void rocket()
    {
        if (rocketTime > rocketInter)
        {
            money += rocketProduction;
            rocketTime = 0;
        }
    }
    private void nuke()
    {
        if (nukeTime > nukeInter)
        {
            money += nukeProduction;
            nukeTime = 0;
        }
    }
    private void ufo()
    {
        if (ufoTime > ufoInter)
        {
            money += ufoProduction;
            ufoTime = 0;
        }
    }
    private void black()
    {
        if (blackTime > blackInter)
        {
            money += blackProduction;
            blackTime = 0;
        }
    }
    private void worm()
    {
        if (wormTime > wormInter)
        {
            money += wormProduction;
            wormTime = 0;
        }
    }
}
