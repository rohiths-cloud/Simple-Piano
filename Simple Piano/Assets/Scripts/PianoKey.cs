using UnityEngine;
using UnityEngine.EventSystems;

public class PianoKey : MonoBehaviour, IPointerDownHandler
{
    public KeyController keyControl;

    public enum Key
    {
        LowC, LowD, LowE, LowF, LowG, LowA, LowB,
        LowCs, LowDs, LowFs, LowGs, LowAs,

        HighC, HighD, HighE, HighF, HighG, HighA, HighB,
        HighCs, HighDs, HighFs, HighGs, HighAs, AutoSong
    }

    public Key key;

    public void OnPointerDown(PointerEventData eventData)
    {
        switch (key)
        {
            case Key.LowC: keyControl.PlayLowC(); break;
            case Key.LowD: keyControl.PlayLowD(); break;
            case Key.LowE: keyControl.PlayLowE(); break;
            case Key.LowF: keyControl.PlayLowF(); break;
            case Key.LowG: keyControl.PlayLowG(); break;
            case Key.LowA: keyControl.PlayLowA(); break;
            case Key.LowB: keyControl.PlayLowB(); break;

            case Key.LowCs: keyControl.PlayLowCs(); break;
            case Key.LowDs: keyControl.PlayLowDs(); break;
            case Key.LowFs: keyControl.PlayLowFs(); break;
            case Key.LowGs: keyControl.PlayLowGs(); break;
            case Key.LowAs: keyControl.PlayLowAs(); break;

            case Key.HighC: keyControl.PlayHighC(); break;
            case Key.HighD: keyControl.PlayHighD(); break;
            case Key.HighE: keyControl.PlayHighE(); break;
            case Key.HighF: keyControl.PlayHighF(); break;
            case Key.HighG: keyControl.PlayHighG(); break;
            case Key.HighA: keyControl.PlayHighA(); break;
            case Key.HighB: keyControl.PlayHighB(); break;

            case Key.HighCs: keyControl.PlayHighCs(); break;
            case Key.HighDs: keyControl.PlayHighDs(); break;
            case Key.HighFs: keyControl.PlayHighFs(); break;
            case Key.HighGs: keyControl.PlayHighGs(); break;
            case Key.HighAs: keyControl.PlayHighAs(); break;
            case Key.AutoSong: keyControl.StartSong(); break;
        }
    }
}