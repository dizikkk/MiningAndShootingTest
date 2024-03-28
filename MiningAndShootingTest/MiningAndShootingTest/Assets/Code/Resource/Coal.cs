using DG.Tweening;
using UnityEngine;

namespace MiningAndShooting
{
    public class Coal : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent(out Player player))
                transform.DOMove(player.transform.position, 0.5f)
                    .OnComplete(() => Destroy(gameObject));
        }
    }
}