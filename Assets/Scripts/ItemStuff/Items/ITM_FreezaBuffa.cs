using UnityEngine;

public class ITM_FreezaBuffa : BaseItem
{
    public override bool OnUse()
    {
        GameControllerScript.Instance.baldiScrpt.IncreaseWaitTime(20);
        //Miko
        //Alger
        //Yellow Face
        GameControllerScript.Instance.player.SpeedUp(2, 3);
        GameControllerScript.Instance.player.Invincibility(20);
        GameControllerScript.Instance.audioDevice.PlayOneShot(sound);
        return true;
    }

    public AudioClip sound;
}
