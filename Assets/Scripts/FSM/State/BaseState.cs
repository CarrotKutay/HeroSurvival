using System.Collections;
using UnityEngine;

namespace FSM.State
{
    public abstract class BaseState : IBaseState
    {
        private IStateMachine stateMachine;
        protected IStateMachine StateMachine { get; private set; }
        
        protected BaseState(IStateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }
        
        public virtual void RunState()
        {
            // run state
            Debug.Log($"running state {this}");
        }
    }

    public abstract class BaseSubState<TState>
    {
        private TState parentState;
        protected TState ParentState { get => parentState; private set => parentState = value; }

        protected BaseSubState(TState state)
        {
            ParentState = state;
        }

        #region OnEnter / OnExit Behavior

        public virtual void OnEnter()
        {
            return;
        }

        public virtual void OnExit()
        {
            return;
        }

        #endregion
        
        public virtual void RunSubState()
        {
            Debug.Log($"running sub-state {this}");
        }
    }
}