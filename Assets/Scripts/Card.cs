using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] GameObject cardText;

    public int church;
    public int army;
    public int science;
    public int rich;

    public void OnMouseDown()
    {
        if (gameObject.GetComponent<SpriteRenderer>().enabled)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

            church = Random.Range(-5, 5);
            army = UnityEngine.Random.Range(-5, 5);
            science = UnityEngine.Random.Range(-5, 5);
            rich = UnityEngine.Random.Range(-5, 5);

            cardText.GetComponent<TextMesh>().text = "Ебаный закон!\n" + "church: "
                + church + "\narmy: " + army + "\nscience: " + science + "\nrich: " + rich;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            cardText.GetComponent<TextMesh>().text = "";
        }  
    }
}
