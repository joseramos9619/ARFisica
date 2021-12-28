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

    public void cargar(){
        m_pre1.sprite = Resources.Load<Sprite>("Img/MRU (1)");
        m_pre2.sprite = Resources.Load<Sprite>("Img/MRU (3)");
        m_pre3.sprite = Resources.Load<Sprite>("Img/MRU (4)");
        m_pre4.sprite = Resources.Load<Sprite>("Img/MRU (5)");
        m_pre5.sprite = Resources.Load<Sprite>("Img/MRU (6)");
        m_exame.SetActive(true);
        m_opcion.SetActive(false);
    }
}
