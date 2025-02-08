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
}

public class Program
{
    public static void Main()
    {
        string targetAddress = "127.0.0.1";
        int targetPort = 7073;
        int targetPlayerIndex = 1;
        Ninja player = new Ninja(targetAddress, targetPort, targetPlayerIndex, "Marcel");

        //A solution to the level 1 that is not optimized
        //ProcessLevels.ProcessLevelOne(player);

        while (true)
        {
            // Restart the level
            player.TapRestart();
            player.TapShuriken();

            // Move right and wait
            player.StartMoveRight();
            player.WaitForSeconds(0.35);
            player.StopMoveRight();
            player.WaitForSeconds(0.1);

            // Jump and move left
            player.StartJump();
            player.StartMoveLeft();
            player.WaitForSeconds(0.5);
            player.StopJump();
            player.StopMoveLeft();
            player.WaitForSeconds(0.1);

            // Jump, move left, and use sword
            player.StartJump();
            player.StartMoveLeft();
            player.StartSword();
            player.WaitForSeconds(0.5);
            player.StopSword();
            player.StopJump();
            player.StopMoveLeft();
            player.WaitForSeconds(0.2);

            // Move right and jump twice
            player.StartMoveRight();
            player.TapJump();
            player.TapJump();
            player.StopMoveRight();

            // Use shuriken and wait
            player.TapShuriken();
            player.WaitForSeconds(3);
        }
    }
}
