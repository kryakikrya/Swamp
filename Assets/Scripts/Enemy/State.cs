using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> transitions = new List<Transition>();

    protected Player Target { get; set; }

    public void Enter(Player target)
    {
        if (enabled == false)
        {
            Target = target;
            enabled = true;

            foreach (Transition transition in transitions)
            {
                transition.enabled = true;
                transition.Init(target);
            }
        }
    }

    public State GetNextState()
    {
        foreach (Transition transition in transitions)
        {
            if (transition.NeedTransit)
            {
                return transition.TargetState;
            }
        }

        return null;
    }

    public void Exit()
    {
        if (enabled == true)
        {
            foreach (var transition in transitions)
            {
                transition.enabled = false;
            }

            enabled = false;
        }
    }
}
