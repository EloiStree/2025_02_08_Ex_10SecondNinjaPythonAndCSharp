using System.Net.Sockets;

public class Ninja
{
    public string Ipv4 { get; set; }
    public int Port { get; set; }
    public int PlayerIndex { get; set; }
    public string NameNinja { get; set; }
    private UdpClient udpClient;

    // Key mappings
    public const int KeySword = 1088;    // key_x
    public const int KeyShuriken = 1090; // key_z
    public const int KeyContinue = 1067; // key_c
    public const int KeyRestart = 1082;  // key_r
    public const int KeyJump = 1038;     // arrow_up
    public const int KeyLeft = 1037;     // arrow_left
    public const int KeyRight = 1039;    // arrow_right
    public const int KeyDown = 1040;     // arrow_down
    public const int KeyEnter = 1013;    // enter
    public const int KeyEscape = 1027;   // escape

    public Ninja(string ipv4, int port, int playerIndex, string nameNinja)
    {
        Ipv4 = ipv4;
        Port = port;
        PlayerIndex = playerIndex;
        NameNinja = nameNinja;
        udpClient = new UdpClient();
    }

    private void PushIndexInteger(int index, int value)
    {
        byte[] bytesToSend = new byte[8];
        Buffer.BlockCopy(BitConverter.GetBytes(index), 0, bytesToSend, 0, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(value), 0, bytesToSend, 4, 4);
        udpClient.Send(bytesToSend, bytesToSend.Length, Ipv4, Port);
    }

    public void PressKey(int keyPress)
    {
        PushIndexInteger(PlayerIndex, keyPress);
    }

    public void ReleaseKey(int keyPress)
    {
        PushIndexInteger(PlayerIndex, keyPress + 1000);
    }

    public void PressForDelay(int keyPress, double delayPress = 0.1, double delayRelease = 0)
    {
        PressKey(keyPress);
        Thread.Sleep((int)(delayPress * 1000));
        ReleaseKey(keyPress);
        Thread.Sleep((int)(delayRelease * 1000));
    }

    public void TapKey(int keyPress)
    {
        PressForDelay(keyPress, 0.1, 0.01);
    }

    public void StartMoveRight() => PressKey(KeyRight);
    public void StopMoveRight() => ReleaseKey(KeyRight);

    public void StartMoveLeft() => PressKey(KeyLeft);
    public void StopMoveLeft() => ReleaseKey(KeyLeft);

    public void StartJump() => PressKey(KeyJump);
    public void StopJump() => ReleaseKey(KeyJump);

    public void StartSword() => PressKey(KeySword);
    public void StopSword() => ReleaseKey(KeySword);

    public void StartShuriken() => PressKey(KeyShuriken);
    public void StopShuriken() => ReleaseKey(KeyShuriken);

    public void TapJump() => TapKey(KeyJump);
    public void TapSword() => TapKey(KeySword);
    public void TapShuriken() => TapKey(KeyShuriken);
    public void TapContinue() => TapKey(KeyContinue);
    public void TapRestart() => TapKey(KeyRestart);

    public void TapX() => TapKey(KeySword);
    public void TapZ() => TapKey(KeyShuriken);
    public void TapC() => TapKey(KeyContinue);
    public void TapR() => TapKey(KeyRestart);
    public void TapEnter() => TapKey(KeyEnter);
    public void TapEscape() => TapKey(KeyEscape);

    public void WaitForMilliseconds(int milliseconds) => Thread.Sleep(milliseconds);
    public void WaitForSeconds(double seconds) => Thread.Sleep((int)(seconds * 1000));
}
