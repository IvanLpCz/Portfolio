using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using player;
using TMPro;

namespace manager
{
    public class bandeja : MonoBehaviour
    {
        [HideInInspector] public bool have1, have2, have3;
        [HideInInspector] public int num1, num2, num3;
        public TMP_Text texto1, texto2, texto3;
        public GameObject[] bebidasPos1, bebidasPos2, bebidasPos3;
        public Animator anim;
        
        private seleccionarBarman SB;

        private void Start()
        {
            SB = GameObject.Find("ManagerBarman").GetComponent<seleccionarBarman>();
        }
        public void inventario()
        {
            //Comprobar si tiene espacio libre en la bandeja
            while (have1 == false || have2 == false || have3 == false)
            {
                //Espacio 1
                if (!have1)
                {
                    have1 = true;
                    if (SB.b1 == true)
                    {
                        //encender bebida
                        bebidasPos1[0].SetActive(true);
                        num1 = 1;
                        texto1.text = "Negroni";
                    }
                    else if (SB.b2 == true)
                    {
                        //encender bebida
                        bebidasPos1[1].SetActive(true);
                        num1 = 2;
                        texto1.text = "Bee's knees";
                    }
                    else if (SB.b3 == true)
                    {
                        //encender bebida
                        bebidasPos1[2].SetActive(true);
                        num1 = 3;
                        texto1.text = "Ron con hielo";
                    }
                    break;
                }
                //Espacio 2
                else if (!have2)
                {
                    have2 = true;
                    if (SB.b1 == true)
                    {
                        //encender bebida
                        bebidasPos2[0].SetActive(true);
                        num2 = 1;
                        texto2.text = "Negroni";
                    }
                    else if (SB.b2 == true)
                    {
                        //encender bebida
                        bebidasPos2[1].SetActive(true);
                        num2 = 2;
                        texto2.text = "Bee's knees";
                    }
                    else if (SB.b3 == true)
                    {
                        //encender bebida
                        bebidasPos2[2].SetActive(true);
                        num2 = 3;
                        texto2.text = "Ron con hielo";
                    }
                    break;
                }
                //Espacio 3
                else if (!have3)
                {
                    have3 = true;
                    if (SB.b1 == true)
                    {
                        //encender bebida
                        bebidasPos3[0].SetActive(true);
                        num3 = 1;
                        texto3.text = "Negroni";
                    }
                    else if (SB.b2 == true)
                    {
                        //encender bebida
                        bebidasPos3[1].SetActive(true);
                        num3 = 2;
                        texto3.text = "Bee's knees";
                    }
                    else if (SB.b3 == true)
                    {
                        //encender bebida
                        bebidasPos3[2].SetActive(true);
                        num3 = 3;
                        texto3.text = "Ron con hielo";
                    }
                    break;
                }
            }
            //Actualizar triger
            if (have1 || have2 || have3)
            {
                anim.SetTrigger("haveDrink");
            }
        }
    }
}
