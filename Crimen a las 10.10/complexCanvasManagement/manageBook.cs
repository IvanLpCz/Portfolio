using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bbook
{
    public class manageBook : MonoBehaviour
    {
        public Button sospechosos, pistas, salir, volverAtrasPistas, volverAtrasSospechosos, isabelaBoton, isabelaVolver, lorenzoBoton, lorenzoVolver, franciscoBoton, franciscoVolver, elenaBoton, elenaVolver, incriminacionVolver;
        public GameObject libro, inicioPagina, sospechososPagina, pistasPagina, isabelaPagina, lorenzoPagina, franciscoPagina, elenaPagina, menuIncriminacion;
        public AudioSource changePage;

        public void openSospechosos()
        {
            inicioPagina.SetActive(false);
            sospechososPagina.SetActive(true);
            changePage.Play();
        }
        public void openPistas()
        {
            inicioPagina.SetActive(false);
            pistasPagina.SetActive(true);
            changePage.Play();
        }
        public void salirLibro()
        {
            Time.timeScale = 1;
            libro.SetActive(false);
            changePage.Play();
        }
        public void retrocederPistas()
        {
            pistasPagina.SetActive(false);
            inicioPagina.SetActive(true);
            changePage.Play();
        }
        public void retrocederSospechosos()
        {
            sospechososPagina.SetActive(false);
            inicioPagina.SetActive(true);
            changePage.Play();
        }
        public void perfilIsabela()
        {
            sospechososPagina.SetActive(false);
            isabelaPagina.SetActive(true);
            changePage.Play();
        }
        public void volverIsabela()
        {
            isabelaPagina.SetActive(false);
            sospechososPagina.SetActive(true);
            changePage.Play();
        }
        public void perfilLorenzo()
        {
            sospechososPagina.SetActive(false);
            lorenzoPagina.SetActive(true);
            changePage.Play();
        }
        public void volverLorenzo()
        {
            lorenzoPagina.SetActive(false);
            sospechososPagina.SetActive(true);
            changePage.Play();
        }
        public void perfilFrancisco()
        {
            sospechososPagina.SetActive(false);
            franciscoPagina.SetActive(true);
            changePage.Play();
        }
        public void volverFrancisco()
        {
            franciscoPagina.SetActive(false);
            sospechososPagina.SetActive(true);
            changePage.Play();
        }
        public void perfilElena()
        {
            sospechososPagina.SetActive(false);
            elenaPagina.SetActive(true);
            changePage.Play();
        }
        public void volverElena()
        {
            elenaPagina.SetActive(false);
            sospechososPagina.SetActive(true);
            changePage.Play();
        }
        public void volverAvatares()
        {
            menuIncriminacion.SetActive(false);
            sospechososPagina.SetActive(true);
            changePage.Play();
        }

    }
}
