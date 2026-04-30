using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPisos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject piso;
    void Start()
    {
        StartCoroutine(InstanciarPiso());
    }

    // Update is called once per frame
    //Se llama 60 veces por segundo.
    void Update()
    {
        
    }

    private IEnumerator InstanciarPiso()
    {
        //Para Siempre...
        while (true)
        {
            //Instanciar el piso: crea una copia del prefab `piso` y la convierte en hijo
            //del Transform del GameObject que contiene este script (this.transform).
            //Atención: la posición y rotación resultante dependerán del prefab y de
            //cómo Unity maneja la sobrecar|ga usada. Si necesitas control absoluto de la
            //posición mundial, usa la sobrecarga con posición y rotación.
            Instantiate(piso, this.transform.position, this.transform.rotation);

            // Espera 1 segundo antes de continuar la ejecución de la coroutine.
            // `yield return new WaitForSeconds(1);` cede el control a Unity y
            // reanuda la coroutine tras 1 segundo sin bloquear el hilo principal.
            yield return new WaitForSeconds(1);
        }
    }
}
