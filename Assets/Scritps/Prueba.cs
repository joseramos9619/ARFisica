using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour
{
    [Header("Preguntas")]
    [SerializeField] private Image m_pre1 = null;
    [SerializeField] private Image m_pre2 = null;
    [SerializeField] private Image m_pre3 = null;
    [SerializeField] private Image m_pre4 = null;
    [SerializeField] private Image m_pre5 = null;

    [Header("Interfaz")]
    [SerializeField] private GameObject m_opcion = null;
    [SerializeField] private GameObject m_exame = null;
    [SerializeField] private GameObject m_barExame = null;
    [SerializeField] private GameObject m_guia = null;
    [SerializeField] private GameObject m_scan = null;
    [SerializeField] private GameObject m_fondo = null;

    public void Guia(){
        m_exame.SetActive(false);
        m_guia.SetActive(true);
        m_barExame.SetActive(false);
    }

    public void Exame(){
        m_exame.SetActive(false);
        m_opcion.SetActive(true);
        m_barExame.SetActive(false);
    }

    public void cargar(int opc)
    {
        if (opc == 1)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

        if (opc == 2)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

        if (opc == 3)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

        if (opc == 4)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

    }
}
