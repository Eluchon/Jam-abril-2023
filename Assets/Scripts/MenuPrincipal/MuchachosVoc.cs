using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuchachosVoc : MonoBehaviour
{
    public GameObject MuchachosIn;
    public GameObject MuchachosVO;
    public GameObject Sabale;
    public GameObject Himn;

    public void boton()
    {
        MuchachosIn.gameObject.SetActive(false);
        MuchachosVO.gameObject.SetActive(true);
        Sabale.gameObject.SetActive(false);
        Himn.gameObject.SetActive(false);
    }
}
