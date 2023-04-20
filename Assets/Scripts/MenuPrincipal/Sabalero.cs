using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sabalero : MonoBehaviour
{
    public GameObject MuchachosIn;
    public GameObject MuchachosVO;
    public GameObject Sabale;
    public GameObject Himn;

    public void boton()
    {
        MuchachosIn.gameObject.SetActive(false);
        MuchachosVO.gameObject.SetActive(false);
        Sabale.gameObject.SetActive(true);
        Himn.gameObject.SetActive(false);
    }
}
