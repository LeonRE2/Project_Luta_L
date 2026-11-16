using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    [SerializeField] private float maxHp = 100f;
    [SerializeField] InputAction deBugDano;
    [SerializeField] private Image hpBar;
    [SerializeField] private Image hpBarFeedback;
    private float hp;

    private void Start()
    {
        hp = maxHp;
        deBugDano.Enable();

    }

    private void Update()
    {
#if UNITY_EDITOR
        if (deBugDano.WasPerformedThisFrame())
        {
            TomarDano(15f);
        }
#endif      
    }
    public void TomarDano(float quantidadeDano)
    {

        hp = hp - quantidadeDano;
        if (hp < 0) hp = 0;

        Debug.Log("Tomou Dano: " + quantidadeDano);

        AttBarraVida();
    }

    public void AttBarraVida()
    {
        hpBar.fillAmount = hp / maxHp;
    }
}