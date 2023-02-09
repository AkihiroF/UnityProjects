using System.Collections.Generic;
using _Source.Command;
using _Source.Input;
using UnityEngine;
using UnityEngine.UIElements;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private CommandInvoker invoker;
        [SerializeField] private GameObject prefabObj;
        [SerializeField] private GameObject player;
        private void Awake()
        {
            Bind(new PlayerInput(), new InputHandler(invoker, Camera.main, new List<ICommand>()
            {
                new FirstDo(prefabObj),
                new SecondDo(player.transform)
            }));
        }

        private void Bind(PlayerInput input, InputHandler handler)
        {
            input.Actor.Enable();
            input.Actor.LKM.performed += handler.LkmDo;
            input.Actor.PKM.performed += handler.PkmDo;
            input.Actor.Return.performed += handler.ReturnDo;
        }
    }
}