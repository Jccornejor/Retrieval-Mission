using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class MineralIndicator : MonoBehaviour
    {
        public GameObject Target;
        public SpriteRenderer renderer;
        public Light light;
        void Start()
        {
            Target = GameObject.FindGameObjectWithTag("Player");
            renderer = GetComponent<SpriteRenderer>();
            light = GetComponent<Light>();
        }

        void Update()
        {
            transform.LookAt(Target.transform);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {

                renderer.enabled = false;
                light.enabled = false;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {

                renderer.enabled = true;
                light.enabled = true;
            }
        }
    }
}
