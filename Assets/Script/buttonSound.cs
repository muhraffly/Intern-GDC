using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{
    public void creditsBtn()
    {
        FindObjectOfType<AudioManager>().Play("buttonEff");
    }
}
