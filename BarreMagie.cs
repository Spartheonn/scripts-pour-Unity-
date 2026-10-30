using UnityEngine;
using UnityEngine.UI;

public class BarreMagie : MonoBehaviour
{
    public Slider slider;
    public float magieMax = 100f;
    private float magieActuelle;
    public float tauxRecharge = 10f;

    void Start()
    {
        magieActuelle = magieMax;
        UpdateBarreDeMagie();
    }

    public void UseSpell(float coutSort)
    {
        magieActuelle -= coutSort;
        magieActuelle = Mathf.Clamp(magieActuelle, 0f, magieMax);
        UpdateBarreDeMagie();
    }

    public void RegenMagie(float quantite)
    {
        magieActuelle += quantite;
        magieActuelle = Mathf.Clamp(magieActuelle, 0f, magieMax);
        UpdateBarreDeMagie();
    }

    private void UpdateBarreDeMagie()
    {
        slider.value = magieActuelle / magieMax;
        magieActuelle = Mathf.Clamp(magieActuelle, 0f, magieMax);
    }
}
