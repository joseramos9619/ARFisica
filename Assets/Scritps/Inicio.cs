using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    [Header("Interfas")]
    [SerializeField] private GameObject m_opc = null;
    [SerializeField] private GameObject m_guia = null;
    [SerializeField] private GameObject m_examen = null;

    public void volver()
    {
        m_guia.SetActive(false);
        m_examen.SetActive(false);
        m_opc.SetActive(true);
    }

    public void guia()
    {
        m_guia.SetActive(true);
        m_examen.SetActive(false);
        m_opc.SetActive(false);
    }

    public void examen()
    {
        m_guia.SetActive(false);
        m_examen.SetActive(true);
        m_opc.SetActive(false);
    }
}
