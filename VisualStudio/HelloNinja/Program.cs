using System;
using System.Net;
using System.Text;
using System.Threading;

public class ProcessLevels
{
    public static void ProcessLevelOne(Ninja theNinja)
    {
        theNinja.TapRestart();
        theNinja.WaitForSeconds(0.35);
        theNinja.TapShuriken();

        theNinja.StartMoveRight();
        theNinja.WaitForSeconds(0.35);
        theNinja.StopMoveRight();
        theNinja.WaitForSeconds(0.1);

        theNinja.StartJump();
        theNinja.StartMoveLeft();
        theNinja.WaitForSeconds(0.45);
        theNinja.StopJump();
        theNinja.StopMoveLeft();
        theNinja.WaitForSeconds(0.05);

        theNinja.StartJump();
        theNinja.StartMoveLeft();
        theNinja.StartSword();
        theNinja.WaitForSeconds(0.5);
        theNinja.StopSword();
        theNinja.StopJump();
        theNinja.StopMoveLeft();
        theNinja.WaitForSeconds(0.2);

        theNinja.StartMoveRight();
        theNinja.TapJump();
        theNinja.TapJump();
        theNinja.StopMoveRight();
        theNinja.WaitForSeconds(0.3);

        theNinja.TapShuriken();
        theNinja.WaitForSeconds(3);
    }

    public static void YourCodeForLevel1(Ninja theNinja)
    {
        // Add your code here to make less than 2 seconds in level 1.
    }

    public static void YourCodeForLevel2(Ninja theNinja)
    {
        // Add your code here to make less than 2 seconds in level 2.
    }

    public static void YourCodeForLevel3(Ninja theNinja)
    {
        // Add your code here to make less than 2 seconds in level 3.
    }
}

public class Program
{
    public static void Main()
    {
        string targetAddress = "127.0.0.1";
        int targetPort = 7073;
        int targetPlayerIndex = 1;
        Ninja player = new Ninja(targetAddress, targetPort, targetPlayerIndex, "Marcel");

        string gameMode = "DEMO";  // Change this to "LEVELS" or "DEMO" as needed

        while (true)
        {
            switch (gameMode)
            {
                case "DEMO":
                    Console.WriteLine("DEMO MODE");
                    while (true)
                    {
                        ProcessLevels.ProcessLevelOne(player);
                    }

                case "LEVELS":
                    Console.WriteLine("LEVELS MODE");
                    ProcessLevels.YourCodeForLevel1(player);
                    player.TapContinue();
                    player.WaitForMilliseconds(1000);
                    ProcessLevels.YourCodeForLevel2(player);
                    player.TapContinue();
                    player.WaitForMilliseconds(1000);
                    ProcessLevels.YourCodeForLevel3(player);
                    break;

                case "SPEED":
                    Console.WriteLine("SPEED MODE");
                    while (true)
                    {
                        player.TapRestart();
                        player.WaitForMilliseconds(300);
                        ProcessLevels.YourCodeForLevel1(player);
                    }

                default:
                    Console.WriteLine("Unknown game mode.");
                    break;
            }
        }
    }
}
