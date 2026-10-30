using UnityEngine;
using UnityEngine.UI;

public class VieBarre : MonoBehaviour
{
    public Slider slider;
    public float vieMax = 100f;
    public float vieActuelle;

    void Start()
    {
        vieActuelle = vieMax;
        UpdateBarreDeVie();
    }

   public void Degats(float degats)
    {
        vieActuelle -= degats;
        vieActuelle = Mathf.Clamp(vieActuelle, 0f, vieMax);
        UpdateBarreDeVie();
    }

    public void Guerir(float soins)
    {
        vieActuelle += soins;
        vieActuelle = Mathf.Clamp(vieActuelle, 0f, vieMax);
        UpdateBarreDeVie();
    }
   
    private void UpdateBarreDeVie()
    {
        slider.value = vieActuelle / vieMax;
    }
}
