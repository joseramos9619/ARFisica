using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{


    [Header("Interfas")]
    [SerializeField] private GameObject m_scan = null;
    [SerializeField] private GameObject m_guia = null;
    [SerializeField] private GameObject m_examen = null;
    [SerializeField] private GameObject m_fondo = null;
    [SerializeField] private GameObject m_tema = null;
    [SerializeField] private GameObject m_guiaActive = null;
    [SerializeField] private GameObject m_ExaActive = null;

    

    public void scan()
    {
        m_fondo.SetActive(false);
        m_scan.SetActive(true);
    }

    public void guia()
    {
        m_guia.SetActive(true);
        m_examen.SetActive(false);
        m_scan.SetActive(false);
        m_tema.SetActive(false);
        m_guiaActive.SetActive(true);
        m_ExaActive.SetActive(false);
    }

    public void examen()
    {
        m_guia.SetActive(false);
        m_examen.SetActive(true);
        m_scan.SetActive(false);
        m_tema.SetActive(false);
        m_guiaActive.SetActive(false);
        m_ExaActive.SetActive(true);
    }

    public void volver(){
        m_fondo.SetActive(true);
        m_scan.SetActive(false);
    }

    public void tema(){
        m_guia.SetActive(false);
        m_examen.SetActive(false);
        m_scan.SetActive(false);
        m_tema.SetActive(true);
        m_guiaActive.SetActive(false);
        m_ExaActive.SetActive(false);

    }

}
