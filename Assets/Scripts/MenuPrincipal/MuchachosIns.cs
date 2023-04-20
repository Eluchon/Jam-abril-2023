using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MuchachosIns : MonoBehaviour
{
    public GameObject MuchachosIn;
    public GameObject MuchachosVO;
    public GameObject Sabale;
    public GameObject Himn;

    public void boton()
    {
        MuchachosIn.gameObject.SetActive(true);
        MuchachosVO.gameObject.SetActive(false);
        Sabale.gameObject.SetActive(false);
        Himn.gameObject.SetActive(false);
    }
}
