using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cook : MonoBehaviour
{
   

    public void Cooking()
    {
         Timer.timer += 1;
         Milanesa.cooking -= 1;
    }
}
