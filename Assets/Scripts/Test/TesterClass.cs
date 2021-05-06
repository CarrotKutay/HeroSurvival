using FSM.GameStateMachine;
using FSM.State;
using FSM.State.GameStates;
using ScriptableObjects;
using UnityEngine;

namespace Test
{
    public class TesterClass : MonoBehaviour
    {
        private GameStateMachine gameStateMachine;
        [SerializeField] private StateEvent stateEvent;

        private void Awake()
        {
            gameStateMachine = FindObjectOfType<GameStateMachine>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                stateEvent.TriggerStateChange(
                    gameStateMachine.GetState(typeof(GameStatePause)));
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                stateEvent.TriggerStateChange(
                    gameStateMachine.GetState(typeof(GameStatePlay)));
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                stateEvent.TriggerStateChange(
                    gameStateMachine.GetState(typeof(GameStateExit)));
            }
        }
    }
}