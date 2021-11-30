using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject m_loginUi = null;
    [SerializeField] private GameObject m_registerUi = null;

    [SerializeField] private InputField m_userInput = null;
    [SerializeField] private InputField m_emailInput = null;
    [SerializeField] private InputField m_passInput = null;
    [SerializeField] private InputField m_veripassInput = null;
    [SerializeField] private Text m_mens = null;

    private Netword m_netword = null;

    private void Awake()
    {
        m_netword = GameObject.FindObjectOfType<Netword>();
    }

    public void verregisterui()
    {
        m_loginUi.SetActive(false);
        m_registerUi.SetActive(true);
    }

    public void veruserui()
    {
        m_loginUi.SetActive(true);
        m_registerUi.SetActive(false);
    }

    public void Registrar()
    {
        if (m_userInput.text == "" || m_emailInput.text == "" || m_passInput.text == "" || m_veripassInput.text == "")
        {
            m_mens.text = "Por favor llene todos los campos";
            return;
        }

        if (m_passInput.text == m_veripassInput.text)
        {
            m_mens.text = "Procesando...";

            m_netword.Guardar(m_userInput.text, m_emailInput.text, m_passInput.text, delegate (Response response)
            {
                m_mens.text = response.mens;
            });
        }
        else
        {
            m_mens.text = "La contraseña no coinside";
        }
    }
}
