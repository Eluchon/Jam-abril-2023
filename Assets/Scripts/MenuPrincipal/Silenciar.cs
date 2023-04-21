using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silenciar : MonoBehaviour
{
    public GameObject MuchachosIn;
    public GameObject MuchachosVO;
    public GameObject Sabale;
    public GameObject Himn;

    public void boton()
    {
        MuchachosIn.gameObject.SetActive(false);
        MuchachosVO.gameObject.SetActive(false);
        Sabale.gameObject.SetActive(false);
        Himn.gameObject.SetActive(false);
    }
}
