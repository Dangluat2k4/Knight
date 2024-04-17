using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.LucidEditor;


namespace Cainos.PixelArtPlatformer_VillageProps
{
    public class Chest : MonoBehaviour
    {
        [FoldoutGroup("Reference")]
        public Animator animator;
        public GameObject explosionPrefab; // Prefab của hiệu ứng vụ nổ
        public GameObject applePrefab;

        [FoldoutGroup("Runtime"), ShowInInspector, DisableInEditMode]
        public bool IsOpened
        {
            get { return isOpened; }
            set
            {
                isOpened = value;
                animator.SetBool("IsOpened", isOpened);
            }
        }
        private bool isOpened;

        [FoldoutGroup("Runtime"),Button("Open"), HorizontalGroup("Runtime/Button")]
        public void Open()
        {
            IsOpened = true;
        }

        [FoldoutGroup("Runtime"), Button("Close"), HorizontalGroup("Runtime/Button")]
        public void Close()
        {
            IsOpened = false;
        }
        public void DestroyChest()
        {
            // Tạo ra hiệu ứng vụ nổ
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            // Hủy bỏ hòm rương sau một khoảng thời gian
            Destroy(gameObject, 0.75f);
            Destroy(explosion, 1.2f);

            // Gọi coroutine để đợi cho vụ nổ hoàn thành trước khi tạo ra item quả táo
            
        }        
    }
}
