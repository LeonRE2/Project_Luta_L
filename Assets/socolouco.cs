using UnityEngine;

public class socolouco : MonoBehaviour
{
    [SerializeField] private Transform maoDireita;
    [SerializeField] private float socoDireitaAlcance = 0.5f;
    [SerializeField] private LayerMask Personagem;
    public void SocoDireita()
    {
        Collider[] acertos = Physics.OverlapSphere(maoDireita.position,
        socoDireitaAlcance, Personagem);
        foreach (Collider c in acertos)
        {
            if (c.transform != this.transform)
            {
                c.transform.GetComponent<Hp>().TomarDano(10f);
            }
        }
    }
}
